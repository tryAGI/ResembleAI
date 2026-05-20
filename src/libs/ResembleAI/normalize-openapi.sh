#!/usr/bin/env bash
set -euo pipefail

input_path="${1:-openapi.yaml}"
temp_path="$(mktemp)"

cleanup() {
  rm -f "$temp_path"
}

trap cleanup EXIT

jq '
  def cluster_server: [{"url": "https://f.cluster.resemble.ai"}];
  def app_server: [{"url": "https://app.resemble.ai/api/v2"}];
  def account_item_schema($title):
    {
      "type": "object",
      "properties": {
        "email": { "type": "string" },
        "first_name": { "type": "string" },
        "last_name": { "type": "string" },
        "created_at": { "type": "string", "format": "date-time" },
        "teams": { "type": "integer" }
      },
      "title": $title
    };
  def teams_item_schema($title):
    {
      "type": "object",
      "properties": {
        "uuid": { "type": "string" },
        "name": { "type": "string" },
        "plan": { "type": "string" },
        "voice_limit": { "type": "integer" },
        "units": { "type": "string" },
        "rate": { "type": "number" },
        "current_usage": { "type": "integer" }
      },
      "title": $title
    };
  def billing_usage_schema($title):
    {
      "type": "object",
      "properties": {
        "detect": { "type": "number" },
        "synth": { "type": "string" }
      },
      "title": $title
    };
  def project_item_schema($title):
    {
      "type": "object",
      "properties": {
        "uuid": { "type": "string" },
        "name": { "type": "string" },
        "description": { "type": "string" },
        "created_at": { "type": "string", "format": "date-time" },
        "updated_at": { "type": "string", "format": "date-time" },
        "is_collaborative": { "type": "boolean" },
        "is_archived": { "type": "boolean" }
      },
      "title": $title
    };
  def voice_status_schema($title):
    {
      "type": "object",
      "properties": {
        "status": { "type": "string" }
      },
      "title": $title
    };
  def voice_component_status_schema($title):
    {
      "type": "object",
      "properties": {
        "text_to_speech": voice_status_schema("VoicesComponentStatusTextToSpeech"),
        "fill": voice_status_schema("VoicesComponentStatusFill"),
        "voice_conversion": voice_status_schema("VoicesComponentStatusVoiceConversion")
      },
      "title": $title
    };
  def voice_api_support_schema($title):
    {
      "type": "object",
      "properties": {
        "sync": { "type": "boolean" },
        "async": { "type": "boolean" },
        "direct_synthesis": { "type": "boolean" },
        "streaming": { "type": "boolean" }
      },
      "title": $title
    };
  def voice_item_schema($title):
    {
      "type": "object",
      "properties": {
        "uuid": { "type": "string" },
        "name": { "type": "string" },
        "status": { "type": "string" },
        "created_at": { "type": "string", "format": "date-time" },
        "updated_at": { "type": "string", "format": "date-time" },
        "default_language": { "type": "string" },
        "voice_type": { "type": "string" },
        "voice_status": { "type": "string" },
        "supported_languages": {
          "type": "array",
          "items": { "type": "string" }
        },
        "component_status": voice_component_status_schema("VoicesComponentStatus"),
        "api_support": voice_api_support_schema("VoicesApiSupport"),
        "source": { "type": "string" }
      },
      "title": $title
    };
  .paths |= with_entries(
    .value = (
      .value + {
        "servers": (
          if (.key == "/synthesize" or .key == "/stream")
          then cluster_server
          else app_server
          end
        )
      }
    )
  )
  | .components.schemas.AccountGetResponsesContentApplicationJsonSchemaItem =
      account_item_schema("AccountGetResponsesContentApplicationJsonSchemaItem")
  | .components.schemas.AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems =
      teams_item_schema("AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems")
  | .components.schemas.AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem =
      billing_usage_schema("AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem")
  | .components.schemas["Account_getBillingUsage_Response_200"].properties = {
      "success": { "type": "boolean" },
      "items": { "$ref": "#/components/schemas/AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem" }
    }
  | .components.schemas.ProjectsGetResponsesContentApplicationJsonSchemaItemsItems =
      project_item_schema("ProjectsGetResponsesContentApplicationJsonSchemaItemsItems")
  | .components.schemas.ProjectsPostResponsesContentApplicationJsonSchemaItem =
      project_item_schema("ProjectsPostResponsesContentApplicationJsonSchemaItem")
  | .components.schemas.ProjectsProjectUuidGetResponsesContentApplicationJsonSchemaItem =
      project_item_schema("ProjectsProjectUuidGetResponsesContentApplicationJsonSchemaItem")
  | .components.schemas.ProjectsProjectUuidPutResponsesContentApplicationJsonSchemaItem =
      project_item_schema("ProjectsProjectUuidPutResponsesContentApplicationJsonSchemaItem")
  | .components.schemas.VoicesGetResponsesContentApplicationJsonSchemaItemsItems =
      voice_item_schema("VoicesGetResponsesContentApplicationJsonSchemaItemsItems")
  | .components.schemas.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItem =
      voice_item_schema("VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItem")
  | .components.schemas.VoicesPostResponsesContentApplicationJsonSchemaItem =
      voice_item_schema("VoicesPostResponsesContentApplicationJsonSchemaItem")
' "$input_path" > "$temp_path"

mv "$temp_path" "$input_path"

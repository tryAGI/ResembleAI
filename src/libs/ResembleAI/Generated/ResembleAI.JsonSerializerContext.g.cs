
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter),

            typeof(global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngineJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngineNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngineJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngineNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormatJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormatNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaTurnModeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaTurnModeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchModeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchModeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProviderJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProviderNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersSourceTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersSourceTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectBatchStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectBatchStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySummaryVisibilityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySummaryVisibilityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityIdentityTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityIdentityTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityVisibilityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityVisibilityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityCreateIdentityRequestJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemMetricsJsonConverter),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectItemMetrics?, object>),

            typeof(global::ResembleAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision), TypeInfoPropertyName = "SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat), TypeInfoPropertyName = "SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate), TypeInfoPropertyName = "SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TextToSpeechSynthesizeResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision), TypeInfoPropertyName = "StreamPostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate), TypeInfoPropertyName = "StreamPostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextListTranscriptsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus), TypeInfoPropertyName = "SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextCreateTranscriptResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus), TypeInfoPropertyName = "SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextGetTranscriptResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextUuidAskPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextAskTranscriptQuestionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextUuidQuestionsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextUuidQuestionsGetResponsesContentApplicationJsonSchemaMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextListTranscriptQuestionsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SpeechToTextUuidQuestionsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextUuidQuestionsQuestionUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextGetTranscriptQuestionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus), TypeInfoPropertyName = "AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine), TypeInfoPropertyName = "AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementListAudioEnhancementsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ListAudioEnhancementsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine), TypeInfoPropertyName = "AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus), TypeInfoPropertyName = "AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateAudioEnhancementRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateAudioEnhancementRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus), TypeInfoPropertyName = "AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementGetAudioEnhancementResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.GetAudioEnhancementRequestNotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsListAgentsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables), TypeInfoPropertyName = "AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat), TypeInfoPropertyName = "AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaAsr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode), TypeInfoPropertyName = "AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaTurn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaLlmBuiltInTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaLlm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode), TypeInfoPropertyName = "AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaWebhooksItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSystemTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsCreateAgentResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsGetAgentResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsDeleteAgentResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaDynamicVariables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaAsr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaTurn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaLlm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode), TypeInfoPropertyName = "AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSystemTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidPatchResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUpdateAgentResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidDispatchPostRequestBodyContentApplicationJsonSchemaDynamicVariables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsDispatchAgentResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsGetAgentCapabilitiesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsSystemToolsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsGetSystemToolsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsSystemToolsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidToolsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentToolsListAgentToolsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsAgentUuidToolsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType), TypeInfoPropertyName = "AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidToolsPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentToolsCreateAgentToolResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidToolsToolUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentToolsGetAgentToolResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentToolsDeleteAgentToolResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidToolsToolUuidPatchRequestBodyContentApplicationJsonSchemaToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidToolsToolUuidPatchResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentToolsUpdateAgentToolResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidWebhooksGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentWebhooksListAgentWebhooksResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsAgentUuidWebhooksGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType), TypeInfoPropertyName = "AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidWebhooksPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentWebhooksCreateAgentWebhookResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidWebhooksWebhookUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentWebhooksGetAgentWebhookResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentWebhooksDeleteAgentWebhookResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidWebhooksWebhookUuidPatchRequestBodyContentApplicationJsonSchemaWebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidWebhooksWebhookUuidPatchResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentWebhooksUpdateAgentWebhookResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PhoneNumbersGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentPhoneNumbersListPhoneNumbersResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.PhoneNumbersGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider), TypeInfoPropertyName = "PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaOutboundTrunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaInboundTrunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PhoneNumbersPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentPhoneNumbersCreatePhoneNumberResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PhoneNumbersIdGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentPhoneNumbersGetPhoneNumberResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentPhoneNumbersDeletePhoneNumberResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentPhoneNumbersForceDeletePhoneNumberResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetParametersStatus), TypeInfoPropertyName = "KnowledgeItemsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetParametersSourceType), TypeInfoPropertyName = "KnowledgeItemsGetParametersSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType), TypeInfoPropertyName = "KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus), TypeInfoPropertyName = "KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentKnowledgeBaseListKnowledgeItemsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType), TypeInfoPropertyName = "KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentKnowledgeBaseCreateKnowledgeItemResponse201))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType), TypeInfoPropertyName = "KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus), TypeInfoPropertyName = "KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemAgentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemAgentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentKnowledgeBaseGetKnowledgeItemResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentKnowledgeBaseDeleteKnowledgeItemResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsUuidReingestPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentKnowledgeBaseReingestKnowledgeItemResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidKnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentKnowledgeBaseListAgentKnowledgeItemsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsAgentUuidKnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidKnowledgeItemsPostResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentKnowledgeBaseAttachKnowledgeItemToAgentResponse201))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsAgentUuidKnowledgeItemsPostResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidKnowledgeItemsKnowledgeItemUuidDeleteResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentKnowledgeBaseDetachKnowledgeItemFromAgentResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsAgentUuidKnowledgeItemsKnowledgeItemUuidDeleteResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SecureUploadsCreateSecureUploadResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType), TypeInfoPropertyName = "DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus), TypeInfoPropertyName = "DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality), TypeInfoPropertyName = "DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAudioMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectImageMetricsChildrenItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectImageMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectImageMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectVideoMetricsChildrenItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectVideoMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsExtraParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>), TypeInfoPropertyName = "OneOfDetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>), TypeInfoPropertyName = "OneOfDetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionListDetectionsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality), TypeInfoPropertyName = "DetectPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality), TypeInfoPropertyName = "DetectPostResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType), TypeInfoPropertyName = "DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1Fraud))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment), TypeInfoPropertyName = "DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1Liveness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1DigitallyAltered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription), TypeInfoPropertyName = "DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>), TypeInfoPropertyName = "OneOfDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionCreateDetectionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1Fraud))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1Liveness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1DigitallyAltered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>), TypeInfoPropertyName = "OneOfDetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence, object>), TypeInfoPropertyName = "OneOfDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionGetDetectionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectBatchStatus), TypeInfoPropertyName = "DetectBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionCreateDetectBatchResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionGetDetectBatchResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType), TypeInfoPropertyName = "IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType), TypeInfoPropertyName = "IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligenceRunIntelligenceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType), TypeInfoPropertyName = "IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraud))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment), TypeInfoPropertyName = "IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLiveness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionDigitallyAltered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType), TypeInfoPropertyName = "IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligenceListIntelligencesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType), TypeInfoPropertyName = "IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraud))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment), TypeInfoPropertyName = "IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLiveness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionDigitallyAltered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType), TypeInfoPropertyName = "IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligenceGetIntelligenceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus), TypeInfoPropertyName = "DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceAskDetectIntelligenceQuestionResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus), TypeInfoPropertyName = "DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceGetDetectIntelligenceQuestionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItemsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioSourceTracingListAudioSourceTracingsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioSourceTracingsUuidGetResponsesContentApplicationJsonSchemaItemResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioSourceTracingsUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioSourceTracingGetAudioSourceTracingResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummaryVisibility), TypeInfoPropertyName = "IdentitySummaryVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummaryIdentityType), TypeInfoPropertyName = "IdentitySummaryIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityListIdentitiesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentitySummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityRequest0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType), TypeInfoPropertyName = "IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility), TypeInfoPropertyName = "IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityRequest1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityRequest), TypeInfoPropertyName = "IdentityCreateIdentityRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityDeleteIdentityResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality), TypeInfoPropertyName = "IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityIdentityType), TypeInfoPropertyName = "IdentityIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityVisibility), TypeInfoPropertyName = "IdentityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityEmbeddingsItemsModality), TypeInfoPropertyName = "IdentityEmbeddingsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityEmbeddingsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityProjectsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentityAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentityEmbeddingsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentityProjectsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityDeleteIdentityAttachmentResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality), TypeInfoPropertyName = "IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality), TypeInfoPropertyName = "IdentitySearchPostResponsesContentApplicationJsonSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchIdentitiesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer), TypeInfoPropertyName = "WatermarkApplyPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemMediaType), TypeInfoPropertyName = "WatermarkApplyItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemOperationType), TypeInfoPropertyName = "WatermarkApplyItemOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemStatus), TypeInfoPropertyName = "WatermarkApplyItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemModelVersion), TypeInfoPropertyName = "WatermarkApplyItemModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer), TypeInfoPropertyName = "WatermarkDetectPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMediaType), TypeInfoPropertyName = "WatermarkDetectItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemOperationType), TypeInfoPropertyName = "WatermarkDetectItemOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemStatus), TypeInfoPropertyName = "WatermarkDetectItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemModelVersion), TypeInfoPropertyName = "WatermarkDetectItemModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus), TypeInfoPropertyName = "WatermarkAudioDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems), TypeInfoPropertyName = "WatermarkAudioDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion), TypeInfoPropertyName = "WatermarkAudioModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultStatus), TypeInfoPropertyName = "WatermarkAudioModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.WatermarkAudioModelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus), TypeInfoPropertyName = "WatermarkVisionDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems), TypeInfoPropertyName = "WatermarkVisionDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion), TypeInfoPropertyName = "WatermarkVisionModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultStatus), TypeInfoPropertyName = "WatermarkVisionModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict), TypeInfoPropertyName = "WatermarkVisionDetectionMetricsVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.WatermarkVisionModelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?, object>), TypeInfoPropertyName = "OneOfWatermarkVisionDetectionMetricsVerdictObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMetrics), TypeInfoPropertyName = "WatermarkDetectItemMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.WatermarkDetectItemMetrics?, object>), TypeInfoPropertyName = "OneOfWatermarkDetectItemMetricsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsComponentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsComponentStatusTextToSpeech))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsComponentStatusFill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsComponentStatusVoiceConversion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsApiSupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesListVoicesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatusTextToSpeech))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatusFill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatusVoiceConversion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemApiSupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesCreateVoiceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatusTextToSpeech))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatusFill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatusVoiceConversion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemApiSupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetVoiceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesDeleteVoiceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesBuildVoiceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceDesignGenerateVoiceDesignResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceDesignCreateVoiceFromCandidateResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidRecordingsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.RecordingsListRecordingsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.VoicesVoiceUuidRecordingsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidRecordingsPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.RecordingsCreateRecordingResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidRecordingsRecordingIdGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.RecordingsGetRecordingResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.RecordingsDeleteRecordingResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesVoiceUuidRecordingsRecordingIdPatchResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.RecordingsUpdateRecordingResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TermSubstitutionsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TermSubstitutionsListTermSubstitutionsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.TermSubstitutionsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TermSubstitutionsPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TermSubstitutionsCreateTermSubstitutionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TermSubstitutionsIdGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TermSubstitutionsGetTermSubstitutionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TermSubstitutionsDeleteTermSubstitutionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PronunciationsGetParametersStatus), TypeInfoPropertyName = "PronunciationsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationStatus), TypeInfoPropertyName = "CustomPronunciationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationsListPronunciationsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.CustomPronunciation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationsCreatePronunciationResponse201))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PronunciationsBulkPostResponsesContentApplicationJsonSchemaErrorsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationsBulkCreatePronunciationsResponse201))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.PronunciationsBulkPostResponsesContentApplicationJsonSchemaErrorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationsGetPronunciationResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationsDeletePronunciationResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationsUpdatePronunciationResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceSettingsPresetsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceSettingsPresetsListVoiceSettingsPresetsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.VoiceSettingsPresetsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceSettingsPresetsPostResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceSettingsPresetsCreateVoiceSettingsPresetResponse201))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceSettingsPresetsUuidGetResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceSettingsPresetsGetVoiceSettingsPresetResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceSettingsPresetsDeleteVoiceSettingsPresetResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceSettingsPresetsUuidPatchResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoiceSettingsPresetsUpdateVoiceSettingsPresetResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsListProjectsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.ProjectsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsCreateProjectResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsProjectUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsGetProjectResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsProjectUuidPutResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsUpdateProjectResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsDeleteProjectResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsProjectUuidClipsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ClipsListClipsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.ProjectsProjectUuidClipsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsProjectUuidClipsClipUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ClipsGetClipResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ClipsDeleteClipResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ProjectsProjectUuidClipsClipUuidPatchResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ClipsUpdateClipResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetAccountResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetTeamsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountTeamsTeamUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetTeamResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetBillingUsageResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetVoicesGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetsListDuetVoicesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DuetVoicesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetVoicesPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetsCreateDuetVoiceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetVoicesIdPutResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetsUpdateDuetVoiceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetsDeleteDuetVoiceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetVoicePairsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetsListDuetVoicePairsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DuetVoicePairsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetVoicePairsPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetsCreateDuetVoicePairResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker), TypeInfoPropertyName = "DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetsGenerateDuetResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamSynthesizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateTranscriptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AskTranscriptQuestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateAudioEnhancementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaWebhooksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DispatchAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateAgentToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateAgentToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateAgentWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateAgentWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateKnowledgeItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AttachKnowledgeItemToAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateSecureUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDetectBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.RunIntelligenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AskDetectIntelligenceQuestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateIdentityAttachmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SearchIdentitiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BuildVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.GenerateVoiceDesignRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateVoiceFromCandidateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateRecordingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateRecordingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateTermSubstitutionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreatePronunciationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BulkCreatePronunciationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdatePronunciationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateVoiceSettingsPresetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateVoiceSettingsPresetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateClipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDuetVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateDuetVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDuetVoicePairRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.GenerateDuetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision?), TypeInfoPropertyName = "NullableSynthesizePostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat?), TypeInfoPropertyName = "NullableSynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate?), TypeInfoPropertyName = "NullableSynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision?), TypeInfoPropertyName = "NullableStreamPostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate?), TypeInfoPropertyName = "NullableStreamPostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableSpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableSpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus?), TypeInfoPropertyName = "NullableAudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine?), TypeInfoPropertyName = "NullableAudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine?), TypeInfoPropertyName = "NullableAudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus?), TypeInfoPropertyName = "NullableAudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus?), TypeInfoPropertyName = "NullableAudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables?), TypeInfoPropertyName = "NullableAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat?), TypeInfoPropertyName = "NullableAgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode?), TypeInfoPropertyName = "NullableAgentsPostRequestBodyContentApplicationJsonSchemaTurnMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode?), TypeInfoPropertyName = "NullableAgentsPostRequestBodyContentApplicationJsonSchemaSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode?), TypeInfoPropertyName = "NullableAgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType?), TypeInfoPropertyName = "NullableAgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter),

            typeof(global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngineJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngineNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngineJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngineNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormatJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormatNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaTurnModeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaTurnModeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchModeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchModeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProviderJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProviderNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersSourceTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersSourceTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectBatchStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectBatchStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySummaryVisibilityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySummaryVisibilityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityIdentityTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityIdentityTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityVisibilityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityVisibilityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityCreateIdentityRequestJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemMetricsJsonConverter),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectItemMetrics?, object>),

            typeof(global::ResembleAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType?), TypeInfoPropertyName = "NullableAgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider?), TypeInfoPropertyName = "NullablePhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetParametersStatus?), TypeInfoPropertyName = "NullableKnowledgeItemsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetParametersSourceType?), TypeInfoPropertyName = "NullableKnowledgeItemsGetParametersSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType?), TypeInfoPropertyName = "NullableKnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus?), TypeInfoPropertyName = "NullableKnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType?), TypeInfoPropertyName = "NullableKnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType?), TypeInfoPropertyName = "NullableKnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableKnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?), TypeInfoPropertyName = "NullableDetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus?), TypeInfoPropertyName = "NullableDetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality?), TypeInfoPropertyName = "NullableDetectGetResponsesContentApplicationJsonSchemaItemsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>?), TypeInfoPropertyName = "NullableOneOfDetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>?), TypeInfoPropertyName = "NullableOneOfDetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality?), TypeInfoPropertyName = "NullableDetectPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>?), TypeInfoPropertyName = "NullableOneOfDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>?), TypeInfoPropertyName = "NullableOneOfDetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence, object>?), TypeInfoPropertyName = "NullableOneOfDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectBatchStatus?), TypeInfoPropertyName = "NullableDetectBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType?), TypeInfoPropertyName = "NullableIntelligencePostRequestBodyContentApplicationJsonSchemaMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType?), TypeInfoPropertyName = "NullableIntelligencePostResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType?), TypeInfoPropertyName = "NullableIntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment?), TypeInfoPropertyName = "NullableIntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?), TypeInfoPropertyName = "NullableIntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType?), TypeInfoPropertyName = "NullableIntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment?), TypeInfoPropertyName = "NullableIntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType?), TypeInfoPropertyName = "NullableIntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableDetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableDetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummaryVisibility?), TypeInfoPropertyName = "NullableIdentitySummaryVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummaryIdentityType?), TypeInfoPropertyName = "NullableIdentitySummaryIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType?), TypeInfoPropertyName = "NullableIdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility?), TypeInfoPropertyName = "NullableIdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityRequest?), TypeInfoPropertyName = "NullableIdentityCreateIdentityRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality?), TypeInfoPropertyName = "NullableIdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityIdentityType?), TypeInfoPropertyName = "NullableIdentityIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityVisibility?), TypeInfoPropertyName = "NullableIdentityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityEmbeddingsItemsModality?), TypeInfoPropertyName = "NullableIdentityEmbeddingsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality?), TypeInfoPropertyName = "NullableIdentitySearchPostRequestBodyContentApplicationJsonSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality?), TypeInfoPropertyName = "NullableIdentitySearchPostResponsesContentApplicationJsonSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer?), TypeInfoPropertyName = "NullableWatermarkApplyPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemMediaType?), TypeInfoPropertyName = "NullableWatermarkApplyItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemOperationType?), TypeInfoPropertyName = "NullableWatermarkApplyItemOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemStatus?), TypeInfoPropertyName = "NullableWatermarkApplyItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemModelVersion?), TypeInfoPropertyName = "NullableWatermarkApplyItemModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer?), TypeInfoPropertyName = "NullableWatermarkDetectPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMediaType?), TypeInfoPropertyName = "NullableWatermarkDetectItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemOperationType?), TypeInfoPropertyName = "NullableWatermarkDetectItemOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemStatus?), TypeInfoPropertyName = "NullableWatermarkDetectItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemModelVersion?), TypeInfoPropertyName = "NullableWatermarkDetectItemModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus?), TypeInfoPropertyName = "NullableWatermarkAudioDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems?), TypeInfoPropertyName = "NullableWatermarkAudioDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion?), TypeInfoPropertyName = "NullableWatermarkAudioModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultStatus?), TypeInfoPropertyName = "NullableWatermarkAudioModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus?), TypeInfoPropertyName = "NullableWatermarkVisionDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems?), TypeInfoPropertyName = "NullableWatermarkVisionDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion?), TypeInfoPropertyName = "NullableWatermarkVisionModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultStatus?), TypeInfoPropertyName = "NullableWatermarkVisionModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?), TypeInfoPropertyName = "NullableWatermarkVisionDetectionMetricsVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?, object>?), TypeInfoPropertyName = "NullableOneOfWatermarkVisionDetectionMetricsVerdictObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMetrics?), TypeInfoPropertyName = "NullableWatermarkDetectItemMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.WatermarkDetectItemMetrics?, object>?), TypeInfoPropertyName = "NullableOneOfWatermarkDetectItemMetricsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PronunciationsGetParametersStatus?), TypeInfoPropertyName = "NullablePronunciationsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationStatus?), TypeInfoPropertyName = "NullableCustomPronunciationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker?), TypeInfoPropertyName = "NullableDuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SpeechToTextUuidQuestionsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsSystemToolsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsAgentUuidToolsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsAgentUuidWebhooksGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.PhoneNumbersGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemAgentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsAgentUuidKnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsAgentUuidKnowledgeItemsPostResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsAgentUuidKnowledgeItemsKnowledgeItemUuidDeleteResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectImageMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectVideoMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentitySummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentityAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentityEmbeddingsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentityProjectsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkAudioModelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkVisionModelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.VoicesVoiceUuidRecordingsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.TermSubstitutionsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.CustomPronunciation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.PronunciationsBulkPostResponsesContentApplicationJsonSchemaErrorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.VoiceSettingsPresetsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.ProjectsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.ProjectsProjectUuidClipsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DuetVoicesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DuetVoicePairsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaWebhooksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItems>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngineJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngineNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngineJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngineNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormatJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormatNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaTurnModeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaTurnModeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchModeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchModeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProviderJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProviderNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersSourceTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsGetParametersSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectBatchStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectBatchStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentitySummaryVisibilityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentitySummaryVisibilityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityIdentityTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityIdentityTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityVisibilityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityVisibilityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyItemStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyItemStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.CustomPronunciationStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.CustomPronunciationStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityCreateIdentityRequestJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemMetricsJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectItemMetrics?, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}
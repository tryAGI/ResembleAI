
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

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModelTypesJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModelTypesNullableJsonConverter),

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

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.VoicesPostRequestBodyContentApplicationJsonSchemaVoiceTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.VoicesPostRequestBodyContentApplicationJsonSchemaVoiceTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkJsonConverter),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMetrics, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMetrics, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics, object>),

            typeof(global::ResembleAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.EditGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEditListAudioEditsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.EditGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.EditPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEditCreateAudioEditResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.EditAudioEditUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEditGetAudioEditResponse200))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes), TypeInfoPropertyName = "DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityListIdentitiesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentityGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaMatchesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchIdentitiesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaMatchesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer), TypeInfoPropertyName = "WatermarkApplyPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType), TypeInfoPropertyName = "WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMetrics, object>), TypeInfoPropertyName = "OneOfWatermarkApplyPostResponsesContentApplicationJsonSchemaItemMetricsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyWatermarkResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType), TypeInfoPropertyName = "WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics, object>), TypeInfoPropertyName = "OneOfWatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkGetWatermarkApplyResultResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer), TypeInfoPropertyName = "WatermarkDetectPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType), TypeInfoPropertyName = "WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMetrics, object>), TypeInfoPropertyName = "OneOfWatermarkDetectPostResponsesContentApplicationJsonSchemaItemMetricsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectWatermarkResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType), TypeInfoPropertyName = "WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark), TypeInfoPropertyName = "WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics, object>), TypeInfoPropertyName = "OneOfWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkGetWatermarkDetectionResultResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsComponentStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsComponentStatusTextToSpeech))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsComponentStatusFill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsComponentStatusVoiceConversion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItemsApiSupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesListVoicesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType), TypeInfoPropertyName = "VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateAudioEditRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateIdentityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SearchIdentitiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ApplyWatermarkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectWatermarkRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SpeechToTextUuidQuestionsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.EditGetResponsesContentApplicationJsonSchemaItemsItems>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentityGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaMatchesItems>))]
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
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
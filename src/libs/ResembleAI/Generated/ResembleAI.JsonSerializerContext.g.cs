
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
            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectC2PaManifestValidationStateJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectC2PaManifestValidationStateNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1FraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1FraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectBatchStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectBatchStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackVoteJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackVoteNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackVerdictJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackVerdictNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectAgentTierJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectAgentTierNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectAgentRunSummaryStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectAgentRunSummaryStatusNullableJsonConverter),

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

            typeof(global::ResembleAI.JsonConverters.SignalSubmissionInputModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalSubmissionInputModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalSubmissionVerdictJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalSubmissionVerdictNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalScoreItemInputModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalScoreItemInputModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalScoreItemVerdictJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalScoreItemVerdictNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalCustomCategoryStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalCustomCategoryStatusNullableJsonConverter),

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

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanPlanTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanPlanTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanBillingIntervalJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanBillingIntervalNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanProductCategoryJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanProductCategoryNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingSubscriptionStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingSubscriptionStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingSubscriptionProductCategoryJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingSubscriptionProductCategoryNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingWalletTransactionTransactionTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingWalletTransactionTransactionTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityCreateIdentityRequestJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemMetricsJsonConverter),

            typeof(global::ResembleAI.JsonConverters.UpdateBillingSubscriptionProductsRequestUnprocessableEntityErrorJsonConverter),

            typeof(global::ResembleAI.JsonConverters.ConfirmBillingSubscriptionPaymentRequestUnprocessableEntityErrorJsonConverter),

            typeof(global::ResembleAI.JsonConverters.ChangeBillingPlanRequestUnprocessableEntityErrorJsonConverter),

            typeof(global::ResembleAI.JsonConverters.UpdateBillingAutoReloadRequestUnprocessableEntityErrorJsonConverter),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectIntelligenceResultDescription?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectFeedbackVerdict?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectAgentRunResultVerdict, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectItemMetrics?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingProductFamily, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingPlanFamily, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingSubscriptionPlanProduct, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingSubscription, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingAutoReloadSetting, object>),

            typeof(global::ResembleAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType), TypeInfoPropertyName = "DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus), TypeInfoPropertyName = "DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality), TypeInfoPropertyName = "DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAudioMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectImageMetricsChildrenItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectImageMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectImageMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectVideoMetricsChildrenItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectVideoMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectC2PaManifestValidationState), TypeInfoPropertyName = "DetectC2PaManifestValidationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectC2paManifest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsExtraParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>), TypeInfoPropertyName = "OneOfDetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>), TypeInfoPropertyName = "OneOfDetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionListDetectionsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality), TypeInfoPropertyName = "DetectPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality), TypeInfoPropertyName = "DetectPostResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus), TypeInfoPropertyName = "DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultStatus), TypeInfoPropertyName = "DetectIntelligenceResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1FraudType), TypeInfoPropertyName = "DetectIntelligenceResultDescriptionOneOf1FraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1Fraud))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1LivenessAssessment), TypeInfoPropertyName = "DetectIntelligenceResultDescriptionOneOf1LivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1Liveness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1DigitallyAltered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescription1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescription), TypeInfoPropertyName = "DetectIntelligenceResultDescription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectIntelligenceResultDescription?, object>), TypeInfoPropertyName = "OneOfDetectIntelligenceResultDescriptionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>), TypeInfoPropertyName = "OneOfDetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence?, object>), TypeInfoPropertyName = "OneOfDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionGetDetectionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectBatchStatus), TypeInfoPropertyName = "DetectBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionCreateDetectBatchResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionGetDetectBatchResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackType), TypeInfoPropertyName = "DetectFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackVote), TypeInfoPropertyName = "DetectFeedbackVote2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackVerdict), TypeInfoPropertyName = "DetectFeedbackVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackMediaType), TypeInfoPropertyName = "DetectFeedbackMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectFeedbackVerdict?, object>), TypeInfoPropertyName = "OneOfDetectFeedbackVerdictObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionGetDetectFeedbackResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType), TypeInfoPropertyName = "DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionCreateDetectFeedbackResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionDeleteDetectFeedbackResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentTier), TypeInfoPropertyName = "DetectAgentTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentsListDetectAgentsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentRunSummaryStatus), TypeInfoPropertyName = "DetectAgentRunSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentRunResultVerdict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentRunResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectAgentRunResultVerdict, object>), TypeInfoPropertyName = "OneOfDetectAgentRunResultVerdictObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentRunSummaryInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentRunSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentsListDetectAgentInvestigationRunsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectAgentRunSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentsGetDetectAgentInvestigationRunResponse200))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionInputModality), TypeInfoPropertyName = "SignalSubmissionInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionVerdict), TypeInfoPropertyName = "SignalSubmissionVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCategoryScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItemInputModality), TypeInfoPropertyName = "SignalScoreItemInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItemVerdict), TypeInfoPropertyName = "SignalScoreItemVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalTopMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalCategoryScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalTopMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalBuiltInCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryStatus), TypeInfoPropertyName = "SignalCustomCategoryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryOverlapsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScenario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalCustomCategoryOverlapsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalScenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCalibrationWarningsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCalibration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalCalibrationWarningsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalBuiltInCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalCustomCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSettingsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SecureUploadsCreateSecureUploadResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision), TypeInfoPropertyName = "SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat), TypeInfoPropertyName = "SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate), TypeInfoPropertyName = "SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TextToSpeechSynthesizeResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision), TypeInfoPropertyName = "StreamPostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate), TypeInfoPropertyName = "StreamPostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaItemsItems))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetAccountResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetTeamsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountTeamsTeamUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetTeamResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanPlanType), TypeInfoPropertyName = "BillingPlanPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanBillingInterval), TypeInfoPropertyName = "BillingPlanBillingInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanFamily))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanProductCategory), TypeInfoPropertyName = "BillingPlanProductCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingProductRateTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingProductFamily))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.BillingProductRateTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingProductFamily, object>), TypeInfoPropertyName = "OneOfBillingProductFamilyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingPlanFamily, object>), TypeInfoPropertyName = "OneOfBillingPlanFamilyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.BillingPlanProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlansResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.BillingPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionStatus), TypeInfoPropertyName = "BillingSubscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionProductCategory), TypeInfoPropertyName = "BillingSubscriptionProductCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionPlanProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingSubscriptionPlanProduct, object>), TypeInfoPropertyName = "OneOfBillingSubscriptionPlanProductObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.BillingSubscriptionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingSubscription, object>), TypeInfoPropertyName = "OneOfBillingSubscriptionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingProductQuantityChange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingUpdateProductsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.BillingProductQuantityChange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPaymentActionRequired))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingValidationErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateBillingSubscriptionProductsRequestUnprocessableEntityError), TypeInfoPropertyName = "UpdateBillingSubscriptionProductsRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingConfirmPaymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ConfirmBillingSubscriptionPaymentRequestUnprocessableEntityError), TypeInfoPropertyName = "ConfirmBillingSubscriptionPaymentRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingChangePlanRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ChangeBillingPlanRequestUnprocessableEntityError), TypeInfoPropertyName = "ChangeBillingPlanRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingWallet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingWalletResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingWalletTransactionTransactionType), TypeInfoPropertyName = "BillingWalletTransactionTransactionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingWalletTransaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingTransactionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.BillingWalletTransaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingAutoReloadSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingAutoReloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingAutoReloadSetting, object>), TypeInfoPropertyName = "OneOfBillingAutoReloadSettingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingUpdateAutoReloadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingWalletUpdateBillingAutoReloadResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateBillingAutoReloadRequestUnprocessableEntityError), TypeInfoPropertyName = "UpdateBillingAutoReloadRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AccountGetBillingUsageResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDetectBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDetectFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.RunDetectAgentInvestigationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.RunIntelligenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AskDetectIntelligenceQuestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateIdentityAttachmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SearchIdentitiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateSignalSubmissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateSecureUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamSynthesizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateTranscriptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AskTranscriptQuestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateAudioEnhancementRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?), TypeInfoPropertyName = "NullableDetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus?), TypeInfoPropertyName = "NullableDetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality?), TypeInfoPropertyName = "NullableDetectGetResponsesContentApplicationJsonSchemaItemsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectC2PaManifestValidationState?), TypeInfoPropertyName = "NullableDetectC2PaManifestValidationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>?), TypeInfoPropertyName = "NullableOneOfDetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>?), TypeInfoPropertyName = "NullableOneOfDetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality?), TypeInfoPropertyName = "NullableDetectPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription2")]
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
            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectC2PaManifestValidationStateJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectC2PaManifestValidationStateNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1FraudTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1FraudTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectBatchStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectBatchStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackVoteJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackVoteNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackVerdictJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackVerdictNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackMediaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectFeedbackMediaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectAgentTierJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectAgentTierNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectAgentRunSummaryStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectAgentRunSummaryStatusNullableJsonConverter),

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

            typeof(global::ResembleAI.JsonConverters.SignalSubmissionInputModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalSubmissionInputModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalSubmissionVerdictJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalSubmissionVerdictNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalScoreItemInputModalityJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalScoreItemInputModalityNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalScoreItemVerdictJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalScoreItemVerdictNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalCustomCategoryStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.SignalCustomCategoryStatusNullableJsonConverter),

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

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanPlanTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanPlanTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanBillingIntervalJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanBillingIntervalNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanProductCategoryJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingPlanProductCategoryNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingSubscriptionStatusJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingSubscriptionStatusNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingSubscriptionProductCategoryJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingSubscriptionProductCategoryNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingWalletTransactionTransactionTypeJsonConverter),

            typeof(global::ResembleAI.JsonConverters.BillingWalletTransactionTransactionTypeNullableJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionJsonConverter),

            typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceJsonConverter),

            typeof(global::ResembleAI.JsonConverters.IdentityCreateIdentityRequestJsonConverter),

            typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemMetricsJsonConverter),

            typeof(global::ResembleAI.JsonConverters.UpdateBillingSubscriptionProductsRequestUnprocessableEntityErrorJsonConverter),

            typeof(global::ResembleAI.JsonConverters.ConfirmBillingSubscriptionPaymentRequestUnprocessableEntityErrorJsonConverter),

            typeof(global::ResembleAI.JsonConverters.ChangeBillingPlanRequestUnprocessableEntityErrorJsonConverter),

            typeof(global::ResembleAI.JsonConverters.UpdateBillingAutoReloadRequestUnprocessableEntityErrorJsonConverter),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectIntelligenceResultDescription?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectFeedbackVerdict?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectAgentRunResultVerdict, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectItemMetrics?, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingProductFamily, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingPlanFamily, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingSubscriptionPlanProduct, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingSubscription, object>),

            typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingAutoReloadSetting, object>),

            typeof(global::ResembleAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>?), TypeInfoPropertyName = "NullableOneOfDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultStatus?), TypeInfoPropertyName = "NullableDetectIntelligenceResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1FraudType?), TypeInfoPropertyName = "NullableDetectIntelligenceResultDescriptionOneOf1FraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1LivenessAssessment?), TypeInfoPropertyName = "NullableDetectIntelligenceResultDescriptionOneOf1LivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescription?), TypeInfoPropertyName = "NullableDetectIntelligenceResultDescription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectIntelligenceResultDescription?, object>?), TypeInfoPropertyName = "NullableOneOfDetectIntelligenceResultDescriptionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>?), TypeInfoPropertyName = "NullableOneOfDetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence?, object>?), TypeInfoPropertyName = "NullableOneOfDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectBatchStatus?), TypeInfoPropertyName = "NullableDetectBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackType?), TypeInfoPropertyName = "NullableDetectFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackVote?), TypeInfoPropertyName = "NullableDetectFeedbackVote2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackVerdict?), TypeInfoPropertyName = "NullableDetectFeedbackVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackMediaType?), TypeInfoPropertyName = "NullableDetectFeedbackMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectFeedbackVerdict?, object>?), TypeInfoPropertyName = "NullableOneOfDetectFeedbackVerdictObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType?), TypeInfoPropertyName = "NullableDetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentTier?), TypeInfoPropertyName = "NullableDetectAgentTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentRunSummaryStatus?), TypeInfoPropertyName = "NullableDetectAgentRunSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.DetectAgentRunResultVerdict, object>?), TypeInfoPropertyName = "NullableOneOfDetectAgentRunResultVerdictObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionInputModality?), TypeInfoPropertyName = "NullableSignalSubmissionInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionVerdict?), TypeInfoPropertyName = "NullableSignalSubmissionVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItemInputModality?), TypeInfoPropertyName = "NullableSignalScoreItemInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItemVerdict?), TypeInfoPropertyName = "NullableSignalScoreItemVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryStatus?), TypeInfoPropertyName = "NullableSignalCustomCategoryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision?), TypeInfoPropertyName = "NullableSynthesizePostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat?), TypeInfoPropertyName = "NullableSynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate?), TypeInfoPropertyName = "NullableSynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision?), TypeInfoPropertyName = "NullableStreamPostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate?), TypeInfoPropertyName = "NullableStreamPostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableSpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableSpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus?), TypeInfoPropertyName = "NullableAudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine?), TypeInfoPropertyName = "NullableAudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine?), TypeInfoPropertyName = "NullableAudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus?), TypeInfoPropertyName = "NullableAudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus?), TypeInfoPropertyName = "NullableAudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PronunciationsGetParametersStatus?), TypeInfoPropertyName = "NullablePronunciationsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationStatus?), TypeInfoPropertyName = "NullableCustomPronunciationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker?), TypeInfoPropertyName = "NullableDuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanPlanType?), TypeInfoPropertyName = "NullableBillingPlanPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanBillingInterval?), TypeInfoPropertyName = "NullableBillingPlanBillingInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanProductCategory?), TypeInfoPropertyName = "NullableBillingPlanProductCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingProductFamily, object>?), TypeInfoPropertyName = "NullableOneOfBillingProductFamilyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingPlanFamily, object>?), TypeInfoPropertyName = "NullableOneOfBillingPlanFamilyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionStatus?), TypeInfoPropertyName = "NullableBillingSubscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionProductCategory?), TypeInfoPropertyName = "NullableBillingSubscriptionProductCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingSubscriptionPlanProduct, object>?), TypeInfoPropertyName = "NullableOneOfBillingSubscriptionPlanProductObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingSubscription, object>?), TypeInfoPropertyName = "NullableOneOfBillingSubscriptionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateBillingSubscriptionProductsRequestUnprocessableEntityError?), TypeInfoPropertyName = "NullableUpdateBillingSubscriptionProductsRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ConfirmBillingSubscriptionPaymentRequestUnprocessableEntityError?), TypeInfoPropertyName = "NullableConfirmBillingSubscriptionPaymentRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ChangeBillingPlanRequestUnprocessableEntityError?), TypeInfoPropertyName = "NullableChangeBillingPlanRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingWalletTransactionTransactionType?), TypeInfoPropertyName = "NullableBillingWalletTransactionTransactionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.OneOf<global::ResembleAI.BillingAutoReloadSetting, object>?), TypeInfoPropertyName = "NullableOneOfBillingAutoReloadSettingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateBillingAutoReloadRequestUnprocessableEntityError?), TypeInfoPropertyName = "NullableUpdateBillingAutoReloadRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectImageMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectVideoMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectIntelligenceResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectAgentRunSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalCategoryScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalTopMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalCustomCategoryOverlapsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalScenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalCalibrationWarningsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalBuiltInCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalCustomCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SpeechToTextUuidQuestionsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.VoicesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.VoicesVoiceUuidRecordingsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.TermSubstitutionsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.CustomPronunciation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.PronunciationsBulkPostResponsesContentApplicationJsonSchemaErrorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.VoiceSettingsPresetsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.ProjectsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.ProjectsProjectUuidClipsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DuetVoicesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DuetVoicePairsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.BillingProductRateTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.BillingPlanProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.BillingPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.BillingSubscriptionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.BillingProductQuantityChange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.BillingWalletTransaction>))]
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
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectC2PaManifestValidationStateJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectC2PaManifestValidationStateNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectIntelligenceResultStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectIntelligenceResultStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1FraudTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1FraudTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectBatchStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectBatchStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectFeedbackTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectFeedbackTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectFeedbackVoteJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectFeedbackVoteNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectFeedbackVerdictJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectFeedbackVerdictNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectFeedbackMediaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectFeedbackMediaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectAgentTierJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectAgentTierNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectAgentRunSummaryStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectAgentRunSummaryStatusNullableJsonConverter());
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
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalSubmissionInputModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalSubmissionInputModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalSubmissionVerdictJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalSubmissionVerdictNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalScoreItemInputModalityJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalScoreItemInputModalityNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalScoreItemVerdictJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalScoreItemVerdictNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalCustomCategoryStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.SignalCustomCategoryStatusNullableJsonConverter());
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
            options.Converters.Add(new global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.CustomPronunciationStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.CustomPronunciationStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingPlanPlanTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingPlanPlanTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingPlanBillingIntervalJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingPlanBillingIntervalNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingPlanProductCategoryJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingPlanProductCategoryNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingSubscriptionStatusJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingSubscriptionStatusNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingSubscriptionProductCategoryJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingSubscriptionProductCategoryNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingWalletTransactionTransactionTypeJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.BillingWalletTransactionTransactionTypeNullableJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityCreateIdentityRequestJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemMetricsJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.UpdateBillingSubscriptionProductsRequestUnprocessableEntityErrorJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.ConfirmBillingSubscriptionPaymentRequestUnprocessableEntityErrorJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.ChangeBillingPlanRequestUnprocessableEntityErrorJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.UpdateBillingAutoReloadRequestUnprocessableEntityErrorJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectIntelligenceResultDescription?, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence?, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectFeedbackVerdict?, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectAgentRunResultVerdict, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectItemMetrics?, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingProductFamily, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingPlanFamily, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingSubscriptionPlanProduct, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingSubscription, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingAutoReloadSetting, object>());
            options.Converters.Add(new global::ResembleAI.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}
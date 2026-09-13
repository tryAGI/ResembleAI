
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType), TypeInfoPropertyName = "DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus), TypeInfoPropertyName = "DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality), TypeInfoPropertyName = "DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectWatermarkAnalysisStatus), TypeInfoPropertyName = "DetectWatermarkAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus), TypeInfoPropertyName = "WatermarkAudioDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems), TypeInfoPropertyName = "WatermarkAudioDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion), TypeInfoPropertyName = "WatermarkAudioModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultStatus), TypeInfoPropertyName = "WatermarkAudioModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectWatermarkAnalysisMetrics), TypeInfoPropertyName = "DetectWatermarkAnalysisMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectWatermarkAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAudioMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectC2PaManifestValidationState), TypeInfoPropertyName = "DetectC2PaManifestValidationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectC2paManifest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsAudioSourceTracing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsIntelligence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsExtraParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionListDetectionsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality), TypeInfoPropertyName = "DetectPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemStatus), TypeInfoPropertyName = "DetectPostResponsesContentApplicationJsonSchemaItemStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionCreateDetectionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDetectionRequestPaymentRequiredError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionGetDetectionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionDeleteDetectionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectBatchStatus), TypeInfoPropertyName = "DetectBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionCreateDetectBatchResponse202))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionGetDetectBatchResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackType), TypeInfoPropertyName = "DetectFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackVote), TypeInfoPropertyName = "DetectFeedbackVote2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackVerdict), TypeInfoPropertyName = "DetectFeedbackVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackMediaType), TypeInfoPropertyName = "DetectFeedbackMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionGetDetectFeedbackResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType), TypeInfoPropertyName = "DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionCreateDetectFeedbackResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DeepfakeDetectionDeleteDetectFeedbackResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDetectBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateDetectFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?), TypeInfoPropertyName = "NullableDetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus?), TypeInfoPropertyName = "NullableDetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality?), TypeInfoPropertyName = "NullableDetectGetResponsesContentApplicationJsonSchemaItemsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectWatermarkAnalysisStatus?), TypeInfoPropertyName = "NullableDetectWatermarkAnalysisStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus?), TypeInfoPropertyName = "NullableWatermarkAudioDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems?), TypeInfoPropertyName = "NullableWatermarkAudioDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion?), TypeInfoPropertyName = "NullableWatermarkAudioModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultStatus?), TypeInfoPropertyName = "NullableWatermarkAudioModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus?), TypeInfoPropertyName = "NullableWatermarkVisionDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems?), TypeInfoPropertyName = "NullableWatermarkVisionDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion?), TypeInfoPropertyName = "NullableWatermarkVisionModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultStatus?), TypeInfoPropertyName = "NullableWatermarkVisionModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?), TypeInfoPropertyName = "NullableWatermarkVisionDetectionMetricsVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectWatermarkAnalysisMetrics?), TypeInfoPropertyName = "NullableDetectWatermarkAnalysisMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectC2PaManifestValidationState?), TypeInfoPropertyName = "NullableDetectC2PaManifestValidationState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality?), TypeInfoPropertyName = "NullableDetectPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription?), TypeInfoPropertyName = "NullableDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultStatus?), TypeInfoPropertyName = "NullableDetectIntelligenceResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1FraudType?), TypeInfoPropertyName = "NullableDetectIntelligenceResultDescriptionOneOf1FraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1LivenessAssessment?), TypeInfoPropertyName = "NullableDetectIntelligenceResultDescriptionOneOf1LivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectIntelligenceResultDescription?), TypeInfoPropertyName = "NullableDetectIntelligenceResultDescription2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality?), TypeInfoPropertyName = "NullableDetectUuidGetResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectBatchStatus?), TypeInfoPropertyName = "NullableDetectBatchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackType?), TypeInfoPropertyName = "NullableDetectFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackVote?), TypeInfoPropertyName = "NullableDetectFeedbackVote2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackVerdict?), TypeInfoPropertyName = "NullableDetectFeedbackVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectFeedbackMediaType?), TypeInfoPropertyName = "NullableDetectFeedbackMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType?), TypeInfoPropertyName = "NullableDetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkAudioModelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkVisionModelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectImageMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectVideoMetricsChildrenItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.DetectIntelligenceResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    internal sealed partial class DeepfakeDetectionSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeepfakeDetectionSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DeepfakeDetectionSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DeepfakeDetectionSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectWatermarkAnalysisMetricsJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType)

                    || typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus?)

                    || typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality)

                    || typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality?)

                    || typeToConvert == typeof(global::ResembleAI.DetectWatermarkAnalysisStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectWatermarkAnalysisStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?)

                    || typeToConvert == typeof(global::ResembleAI.DetectC2PaManifestValidationState)

                    || typeToConvert == typeof(global::ResembleAI.DetectC2PaManifestValidationState?)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality?)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality?)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus?)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType?)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment?)

                    || typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultStatus?)

                    || typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1FraudType)

                    || typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1FraudType?)

                    || typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1LivenessAssessment)

                    || typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1LivenessAssessment?)

                    || typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality)

                    || typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality?)

                    || typeToConvert == typeof(global::ResembleAI.DetectBatchStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectBatchStatus?)

                    || typeToConvert == typeof(global::ResembleAI.DetectFeedbackType)

                    || typeToConvert == typeof(global::ResembleAI.DetectFeedbackType?)

                    || typeToConvert == typeof(global::ResembleAI.DetectFeedbackVote)

                    || typeToConvert == typeof(global::ResembleAI.DetectFeedbackVote?)

                    || typeToConvert == typeof(global::ResembleAI.DetectFeedbackVerdict)

                    || typeToConvert == typeof(global::ResembleAI.DetectFeedbackVerdict?)

                    || typeToConvert == typeof(global::ResembleAI.DetectFeedbackMediaType)

                    || typeToConvert == typeof(global::ResembleAI.DetectFeedbackMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType)

                    || typeToConvert == typeof(global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType))
                {
                    return new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality))
                {
                    return new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality?))
                {
                    return new global::ResembleAI.JsonConverters.DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectWatermarkAnalysisStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectWatermarkAnalysisStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectWatermarkAnalysisStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectWatermarkAnalysisStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectC2PaManifestValidationState))
                {
                    return new global::ResembleAI.JsonConverters.DetectC2PaManifestValidationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectC2PaManifestValidationState?))
                {
                    return new global::ResembleAI.JsonConverters.DetectC2PaManifestValidationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality?))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality?))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType?))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment?))
                {
                    return new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectIntelligenceResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectIntelligenceResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1FraudType))
                {
                    return new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1FraudTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1FraudType?))
                {
                    return new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1FraudTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1LivenessAssessment))
                {
                    return new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1LivenessAssessment?))
                {
                    return new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality))
                {
                    return new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality?))
                {
                    return new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectBatchStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectBatchStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectBatchStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectBatchStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectFeedbackType))
                {
                    return new global::ResembleAI.JsonConverters.DetectFeedbackTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectFeedbackType?))
                {
                    return new global::ResembleAI.JsonConverters.DetectFeedbackTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectFeedbackVote))
                {
                    return new global::ResembleAI.JsonConverters.DetectFeedbackVoteJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectFeedbackVote?))
                {
                    return new global::ResembleAI.JsonConverters.DetectFeedbackVoteNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectFeedbackVerdict))
                {
                    return new global::ResembleAI.JsonConverters.DetectFeedbackVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectFeedbackVerdict?))
                {
                    return new global::ResembleAI.JsonConverters.DetectFeedbackVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectFeedbackMediaType))
                {
                    return new global::ResembleAI.JsonConverters.DetectFeedbackMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectFeedbackMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.DetectFeedbackMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType))
                {
                    return new global::ResembleAI.JsonConverters.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType?))
                {
                    return new global::ResembleAI.JsonConverters.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new DeepfakeDetectionSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
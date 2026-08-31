
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality), TypeInfoPropertyName = "DetectUuidGetResponsesContentApplicationJsonSchemaItemModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMetrics), TypeInfoPropertyName = "WatermarkDetectItemMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementListAudioEnhancementsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ListAudioEnhancementsRequestBadRequestError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlan))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.BillingSubscriptionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality?), TypeInfoPropertyName = "NullableDetectPostRequestBodyContentMultipartFormDataSchemaModality2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentTier?), TypeInfoPropertyName = "NullableDetectAgentTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectAgentRunSummaryStatus?), TypeInfoPropertyName = "NullableDetectAgentRunSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType?), TypeInfoPropertyName = "NullableIntelligencePostRequestBodyContentApplicationJsonSchemaMediaType2")]
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
        })]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMetrics?), TypeInfoPropertyName = "NullableWatermarkDetectItemMetrics2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus?), TypeInfoPropertyName = "NullableAudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus?), TypeInfoPropertyName = "NullableAudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.PronunciationsGetParametersStatus?), TypeInfoPropertyName = "NullablePronunciationsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CustomPronunciationStatus?), TypeInfoPropertyName = "NullableCustomPronunciationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker?), TypeInfoPropertyName = "NullableDuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanPlanType?), TypeInfoPropertyName = "NullableBillingPlanPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanBillingInterval?), TypeInfoPropertyName = "NullableBillingPlanBillingInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingPlanProductCategory?), TypeInfoPropertyName = "NullableBillingPlanProductCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionStatus?), TypeInfoPropertyName = "NullableBillingSubscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingSubscriptionProductCategory?), TypeInfoPropertyName = "NullableBillingSubscriptionProductCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.UpdateBillingSubscriptionProductsRequestUnprocessableEntityError?), TypeInfoPropertyName = "NullableUpdateBillingSubscriptionProductsRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ConfirmBillingSubscriptionPaymentRequestUnprocessableEntityError?), TypeInfoPropertyName = "NullableConfirmBillingSubscriptionPaymentRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.ChangeBillingPlanRequestUnprocessableEntityError?), TypeInfoPropertyName = "NullableChangeBillingPlanRequestUnprocessableEntityError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.BillingWalletTransactionTransactionType?), TypeInfoPropertyName = "NullableBillingWalletTransactionTransactionType2")]
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
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

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
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityCreateIdentityRequestJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemMetricsJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.UpdateBillingSubscriptionProductsRequestUnprocessableEntityErrorJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.ConfirmBillingSubscriptionPaymentRequestUnprocessableEntityErrorJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.ChangeBillingPlanRequestUnprocessableEntityErrorJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.UpdateBillingAutoReloadRequestUnprocessableEntityErrorJsonConverter());
            options.Converters.Add(new global::ResembleAI.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

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

                    || typeToConvert == typeof(global::ResembleAI.DetectC2PaManifestValidationState)

                    || typeToConvert == typeof(global::ResembleAI.DetectC2PaManifestValidationState?)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality)

                    || typeToConvert == typeof(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality?)

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

                    || typeToConvert == typeof(global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType?)

                    || typeToConvert == typeof(global::ResembleAI.DetectAgentTier)

                    || typeToConvert == typeof(global::ResembleAI.DetectAgentTier?)

                    || typeToConvert == typeof(global::ResembleAI.DetectAgentRunSummaryStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectAgentRunSummaryStatus?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySummaryVisibility)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySummaryVisibility?)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySummaryIdentityType)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySummaryIdentityType?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType)

                    || typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility)

                    || typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality)

                    || typeToConvert == typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityIdentityType)

                    || typeToConvert == typeof(global::ResembleAI.IdentityIdentityType?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityVisibility)

                    || typeToConvert == typeof(global::ResembleAI.IdentityVisibility?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityEmbeddingsItemsModality)

                    || typeToConvert == typeof(global::ResembleAI.IdentityEmbeddingsItemsModality?)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality?)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemOperationType)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemOperationType?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemModelVersion)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemModelVersion?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemOperationType)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemOperationType?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemModelVersion)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemModelVersion?)

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

                    || typeToConvert == typeof(global::ResembleAI.SignalSubmissionInputModality)

                    || typeToConvert == typeof(global::ResembleAI.SignalSubmissionInputModality?)

                    || typeToConvert == typeof(global::ResembleAI.SignalSubmissionVerdict)

                    || typeToConvert == typeof(global::ResembleAI.SignalSubmissionVerdict?)

                    || typeToConvert == typeof(global::ResembleAI.SignalScoreItemInputModality)

                    || typeToConvert == typeof(global::ResembleAI.SignalScoreItemInputModality?)

                    || typeToConvert == typeof(global::ResembleAI.SignalScoreItemVerdict)

                    || typeToConvert == typeof(global::ResembleAI.SignalScoreItemVerdict?)

                    || typeToConvert == typeof(global::ResembleAI.SignalCustomCategoryStatus)

                    || typeToConvert == typeof(global::ResembleAI.SignalCustomCategoryStatus?)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision?)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat?)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate?)

                    || typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision)

                    || typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision?)

                    || typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate)

                    || typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate?)

                    || typeToConvert == typeof(global::ResembleAI.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus)

                    || typeToConvert == typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus?)

                    || typeToConvert == typeof(global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus)

                    || typeToConvert == typeof(global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus?)

                    || typeToConvert == typeof(global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus)

                    || typeToConvert == typeof(global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus?)

                    || typeToConvert == typeof(global::ResembleAI.PronunciationsGetParametersStatus)

                    || typeToConvert == typeof(global::ResembleAI.PronunciationsGetParametersStatus?)

                    || typeToConvert == typeof(global::ResembleAI.CustomPronunciationStatus)

                    || typeToConvert == typeof(global::ResembleAI.CustomPronunciationStatus?)

                    || typeToConvert == typeof(global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker)

                    || typeToConvert == typeof(global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker?)

                    || typeToConvert == typeof(global::ResembleAI.BillingPlanPlanType)

                    || typeToConvert == typeof(global::ResembleAI.BillingPlanPlanType?)

                    || typeToConvert == typeof(global::ResembleAI.BillingPlanBillingInterval)

                    || typeToConvert == typeof(global::ResembleAI.BillingPlanBillingInterval?)

                    || typeToConvert == typeof(global::ResembleAI.BillingPlanProductCategory)

                    || typeToConvert == typeof(global::ResembleAI.BillingPlanProductCategory?)

                    || typeToConvert == typeof(global::ResembleAI.BillingSubscriptionStatus)

                    || typeToConvert == typeof(global::ResembleAI.BillingSubscriptionStatus?)

                    || typeToConvert == typeof(global::ResembleAI.BillingSubscriptionProductCategory)

                    || typeToConvert == typeof(global::ResembleAI.BillingSubscriptionProductCategory?)

                    || typeToConvert == typeof(global::ResembleAI.BillingWalletTransactionTransactionType)

                    || typeToConvert == typeof(global::ResembleAI.BillingWalletTransactionTransactionType?);
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

                if (typeToConvert == typeof(global::ResembleAI.DetectAgentTier))
                {
                    return new global::ResembleAI.JsonConverters.DetectAgentTierJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectAgentTier?))
                {
                    return new global::ResembleAI.JsonConverters.DetectAgentTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectAgentRunSummaryStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectAgentRunSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectAgentRunSummaryStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectAgentRunSummaryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySummaryVisibility))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySummaryVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySummaryVisibility?))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySummaryVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySummaryIdentityType))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySummaryIdentityType?))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType))
                {
                    return new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility))
                {
                    return new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality))
                {
                    return new global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityIdentityType))
                {
                    return new global::ResembleAI.JsonConverters.IdentityIdentityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityIdentityType?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityIdentityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityVisibility))
                {
                    return new global::ResembleAI.JsonConverters.IdentityVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityVisibility?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityEmbeddingsItemsModality))
                {
                    return new global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityEmbeddingsItemsModality?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality?))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality?))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemOperationType))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemOperationType?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemModelVersion))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemModelVersion?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemOperationType))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemOperationType?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemModelVersion))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemModelVersion?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionNullableJsonConverter();
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

                if (typeToConvert == typeof(global::ResembleAI.SignalSubmissionInputModality))
                {
                    return new global::ResembleAI.JsonConverters.SignalSubmissionInputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalSubmissionInputModality?))
                {
                    return new global::ResembleAI.JsonConverters.SignalSubmissionInputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalSubmissionVerdict))
                {
                    return new global::ResembleAI.JsonConverters.SignalSubmissionVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalSubmissionVerdict?))
                {
                    return new global::ResembleAI.JsonConverters.SignalSubmissionVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalScoreItemInputModality))
                {
                    return new global::ResembleAI.JsonConverters.SignalScoreItemInputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalScoreItemInputModality?))
                {
                    return new global::ResembleAI.JsonConverters.SignalScoreItemInputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalScoreItemVerdict))
                {
                    return new global::ResembleAI.JsonConverters.SignalScoreItemVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalScoreItemVerdict?))
                {
                    return new global::ResembleAI.JsonConverters.SignalScoreItemVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalCustomCategoryStatus))
                {
                    return new global::ResembleAI.JsonConverters.SignalCustomCategoryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalCustomCategoryStatus?))
                {
                    return new global::ResembleAI.JsonConverters.SignalCustomCategoryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision?))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat?))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate?))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision))
                {
                    return new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision?))
                {
                    return new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate))
                {
                    return new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate?))
                {
                    return new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus))
                {
                    return new global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus?))
                {
                    return new global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus))
                {
                    return new global::ResembleAI.JsonConverters.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus?))
                {
                    return new global::ResembleAI.JsonConverters.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus))
                {
                    return new global::ResembleAI.JsonConverters.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus?))
                {
                    return new global::ResembleAI.JsonConverters.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.PronunciationsGetParametersStatus))
                {
                    return new global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.PronunciationsGetParametersStatus?))
                {
                    return new global::ResembleAI.JsonConverters.PronunciationsGetParametersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.CustomPronunciationStatus))
                {
                    return new global::ResembleAI.JsonConverters.CustomPronunciationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.CustomPronunciationStatus?))
                {
                    return new global::ResembleAI.JsonConverters.CustomPronunciationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker))
                {
                    return new global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker?))
                {
                    return new global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingPlanPlanType))
                {
                    return new global::ResembleAI.JsonConverters.BillingPlanPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingPlanPlanType?))
                {
                    return new global::ResembleAI.JsonConverters.BillingPlanPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingPlanBillingInterval))
                {
                    return new global::ResembleAI.JsonConverters.BillingPlanBillingIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingPlanBillingInterval?))
                {
                    return new global::ResembleAI.JsonConverters.BillingPlanBillingIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingPlanProductCategory))
                {
                    return new global::ResembleAI.JsonConverters.BillingPlanProductCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingPlanProductCategory?))
                {
                    return new global::ResembleAI.JsonConverters.BillingPlanProductCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingSubscriptionStatus))
                {
                    return new global::ResembleAI.JsonConverters.BillingSubscriptionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingSubscriptionStatus?))
                {
                    return new global::ResembleAI.JsonConverters.BillingSubscriptionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingSubscriptionProductCategory))
                {
                    return new global::ResembleAI.JsonConverters.BillingSubscriptionProductCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingSubscriptionProductCategory?))
                {
                    return new global::ResembleAI.JsonConverters.BillingSubscriptionProductCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingWalletTransactionTransactionType))
                {
                    return new global::ResembleAI.JsonConverters.BillingWalletTransactionTransactionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.BillingWalletTransactionTransactionType?))
                {
                    return new global::ResembleAI.JsonConverters.BillingWalletTransactionTransactionTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment
    {
        /// <summary>
        /// 
        /// </summary>
        Inconclusive,
        /// <summary>
        /// 
        /// </summary>
        NotRealPerson,
        /// <summary>
        /// 
        /// </summary>
        RealPerson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment value)
        {
            return value switch
            {
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.Inconclusive => "inconclusive",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.NotRealPerson => "not_real_person",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.RealPerson => "real_person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment? ToEnum(string value)
        {
            return value switch
            {
                "inconclusive" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.Inconclusive,
                "not_real_person" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.NotRealPerson,
                "real_person" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.RealPerson,
                _ => null,
            };
        }
    }
}
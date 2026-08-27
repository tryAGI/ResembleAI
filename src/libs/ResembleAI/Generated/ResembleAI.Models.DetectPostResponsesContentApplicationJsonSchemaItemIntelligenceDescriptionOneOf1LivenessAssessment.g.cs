
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment
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
    public static class DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment value)
        {
            return value switch
            {
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.Inconclusive => "inconclusive",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.NotRealPerson => "not_real_person",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.RealPerson => "real_person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment? ToEnum(string value)
        {
            return value switch
            {
                "inconclusive" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.Inconclusive,
                "not_real_person" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.NotRealPerson,
                "real_person" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1LivenessAssessment.RealPerson,
                _ => null,
            };
        }
    }
}
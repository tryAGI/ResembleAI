
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment
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
    public static class IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment value)
        {
            return value switch
            {
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment.Inconclusive => "inconclusive",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment.NotRealPerson => "not_real_person",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment.RealPerson => "real_person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment? ToEnum(string value)
        {
            return value switch
            {
                "inconclusive" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment.Inconclusive,
                "not_real_person" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment.NotRealPerson,
                "real_person" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment.RealPerson,
                _ => null,
            };
        }
    }
}
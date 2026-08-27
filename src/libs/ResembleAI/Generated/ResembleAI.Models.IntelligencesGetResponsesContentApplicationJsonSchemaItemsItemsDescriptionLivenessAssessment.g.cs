
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment
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
    public static class IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment value)
        {
            return value switch
            {
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment.Inconclusive => "inconclusive",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment.NotRealPerson => "not_real_person",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment.RealPerson => "real_person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment? ToEnum(string value)
        {
            return value switch
            {
                "inconclusive" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment.Inconclusive,
                "not_real_person" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment.NotRealPerson,
                "real_person" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment.RealPerson,
                _ => null,
            };
        }
    }
}
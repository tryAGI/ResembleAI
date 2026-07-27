
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetectIntelligenceResultDescriptionOneOf1LivenessAssessment
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
    public static class DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectIntelligenceResultDescriptionOneOf1LivenessAssessment value)
        {
            return value switch
            {
                DetectIntelligenceResultDescriptionOneOf1LivenessAssessment.Inconclusive => "inconclusive",
                DetectIntelligenceResultDescriptionOneOf1LivenessAssessment.NotRealPerson => "not_real_person",
                DetectIntelligenceResultDescriptionOneOf1LivenessAssessment.RealPerson => "real_person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectIntelligenceResultDescriptionOneOf1LivenessAssessment? ToEnum(string value)
        {
            return value switch
            {
                "inconclusive" => DetectIntelligenceResultDescriptionOneOf1LivenessAssessment.Inconclusive,
                "not_real_person" => DetectIntelligenceResultDescriptionOneOf1LivenessAssessment.NotRealPerson,
                "real_person" => DetectIntelligenceResultDescriptionOneOf1LivenessAssessment.RealPerson,
                _ => null,
            };
        }
    }
}
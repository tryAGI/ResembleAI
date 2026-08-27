
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType
    {
        /// <summary>
        ///
        /// </summary>
        EmploymentFraud,
        /// <summary>
        ///
        /// </summary>
        Extortion,
        /// <summary>
        ///
        /// </summary>
        FinancialFraud,
        /// <summary>
        ///
        /// </summary>
        Impersonation,
        /// <summary>
        ///
        /// </summary>
        InsuranceFraud,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        PoliticalManipulation,
        /// <summary>
        ///
        /// </summary>
        RomanceScam,
        /// <summary>
        ///
        /// </summary>
        SyntheticMediaFraud,
        /// <summary>
        ///
        /// </summary>
        TechSupportScam,
        /// <summary>
        ///
        /// </summary>
        Vishing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType value)
        {
            return value switch
            {
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.EmploymentFraud => "employment_fraud",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Extortion => "extortion",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.FinancialFraud => "financial_fraud",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Impersonation => "impersonation",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.InsuranceFraud => "insurance_fraud",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.None => "none",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Other => "other",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.PoliticalManipulation => "political_manipulation",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.RomanceScam => "romance_scam",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.SyntheticMediaFraud => "synthetic_media_fraud",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.TechSupportScam => "tech_support_scam",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Vishing => "vishing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType? ToEnum(string value)
        {
            return value switch
            {
                "employment_fraud" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.EmploymentFraud,
                "extortion" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Extortion,
                "financial_fraud" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.FinancialFraud,
                "impersonation" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Impersonation,
                "insurance_fraud" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.InsuranceFraud,
                "none" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.None,
                "other" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Other,
                "political_manipulation" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.PoliticalManipulation,
                "romance_scam" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.RomanceScam,
                "synthetic_media_fraud" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.SyntheticMediaFraud,
                "tech_support_scam" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.TechSupportScam,
                "vishing" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Vishing,
                _ => null,
            };
        }
    }
}
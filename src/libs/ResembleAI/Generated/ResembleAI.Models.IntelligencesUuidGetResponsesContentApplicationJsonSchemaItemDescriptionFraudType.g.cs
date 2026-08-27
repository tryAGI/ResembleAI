
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType
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
    public static class IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType value)
        {
            return value switch
            {
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.EmploymentFraud => "employment_fraud",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.Extortion => "extortion",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.FinancialFraud => "financial_fraud",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.Impersonation => "impersonation",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.InsuranceFraud => "insurance_fraud",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.None => "none",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.Other => "other",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.PoliticalManipulation => "political_manipulation",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.RomanceScam => "romance_scam",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.SyntheticMediaFraud => "synthetic_media_fraud",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.TechSupportScam => "tech_support_scam",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.Vishing => "vishing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType? ToEnum(string value)
        {
            return value switch
            {
                "employment_fraud" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.EmploymentFraud,
                "extortion" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.Extortion,
                "financial_fraud" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.FinancialFraud,
                "impersonation" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.Impersonation,
                "insurance_fraud" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.InsuranceFraud,
                "none" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.None,
                "other" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.Other,
                "political_manipulation" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.PoliticalManipulation,
                "romance_scam" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.RomanceScam,
                "synthetic_media_fraud" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.SyntheticMediaFraud,
                "tech_support_scam" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.TechSupportScam,
                "vishing" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType.Vishing,
                _ => null,
            };
        }
    }
}
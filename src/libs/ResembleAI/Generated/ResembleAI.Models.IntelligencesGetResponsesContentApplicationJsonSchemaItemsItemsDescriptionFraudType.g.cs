
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType
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
    public static class IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType value)
        {
            return value switch
            {
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.EmploymentFraud => "employment_fraud",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.Extortion => "extortion",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.FinancialFraud => "financial_fraud",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.Impersonation => "impersonation",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.InsuranceFraud => "insurance_fraud",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.None => "none",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.Other => "other",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.PoliticalManipulation => "political_manipulation",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.RomanceScam => "romance_scam",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.SyntheticMediaFraud => "synthetic_media_fraud",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.TechSupportScam => "tech_support_scam",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.Vishing => "vishing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType? ToEnum(string value)
        {
            return value switch
            {
                "employment_fraud" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.EmploymentFraud,
                "extortion" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.Extortion,
                "financial_fraud" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.FinancialFraud,
                "impersonation" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.Impersonation,
                "insurance_fraud" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.InsuranceFraud,
                "none" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.None,
                "other" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.Other,
                "political_manipulation" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.PoliticalManipulation,
                "romance_scam" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.RomanceScam,
                "synthetic_media_fraud" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.SyntheticMediaFraud,
                "tech_support_scam" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.TechSupportScam,
                "vishing" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType.Vishing,
                _ => null,
            };
        }
    }
}
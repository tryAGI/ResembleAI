
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType
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
    public static class DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType value)
        {
            return value switch
            {
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.EmploymentFraud => "employment_fraud",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Extortion => "extortion",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.FinancialFraud => "financial_fraud",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Impersonation => "impersonation",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.InsuranceFraud => "insurance_fraud",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.None => "none",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Other => "other",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.PoliticalManipulation => "political_manipulation",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.RomanceScam => "romance_scam",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.SyntheticMediaFraud => "synthetic_media_fraud",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.TechSupportScam => "tech_support_scam",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Vishing => "vishing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType? ToEnum(string value)
        {
            return value switch
            {
                "employment_fraud" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.EmploymentFraud,
                "extortion" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Extortion,
                "financial_fraud" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.FinancialFraud,
                "impersonation" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Impersonation,
                "insurance_fraud" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.InsuranceFraud,
                "none" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.None,
                "other" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Other,
                "political_manipulation" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.PoliticalManipulation,
                "romance_scam" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.RomanceScam,
                "synthetic_media_fraud" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.SyntheticMediaFraud,
                "tech_support_scam" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.TechSupportScam,
                "vishing" => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1FraudType.Vishing,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetectIntelligenceResultDescriptionOneOf1FraudType
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
    public static class DetectIntelligenceResultDescriptionOneOf1FraudTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectIntelligenceResultDescriptionOneOf1FraudType value)
        {
            return value switch
            {
                DetectIntelligenceResultDescriptionOneOf1FraudType.EmploymentFraud => "employment_fraud",
                DetectIntelligenceResultDescriptionOneOf1FraudType.Extortion => "extortion",
                DetectIntelligenceResultDescriptionOneOf1FraudType.FinancialFraud => "financial_fraud",
                DetectIntelligenceResultDescriptionOneOf1FraudType.Impersonation => "impersonation",
                DetectIntelligenceResultDescriptionOneOf1FraudType.InsuranceFraud => "insurance_fraud",
                DetectIntelligenceResultDescriptionOneOf1FraudType.None => "none",
                DetectIntelligenceResultDescriptionOneOf1FraudType.Other => "other",
                DetectIntelligenceResultDescriptionOneOf1FraudType.PoliticalManipulation => "political_manipulation",
                DetectIntelligenceResultDescriptionOneOf1FraudType.RomanceScam => "romance_scam",
                DetectIntelligenceResultDescriptionOneOf1FraudType.SyntheticMediaFraud => "synthetic_media_fraud",
                DetectIntelligenceResultDescriptionOneOf1FraudType.TechSupportScam => "tech_support_scam",
                DetectIntelligenceResultDescriptionOneOf1FraudType.Vishing => "vishing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectIntelligenceResultDescriptionOneOf1FraudType? ToEnum(string value)
        {
            return value switch
            {
                "employment_fraud" => DetectIntelligenceResultDescriptionOneOf1FraudType.EmploymentFraud,
                "extortion" => DetectIntelligenceResultDescriptionOneOf1FraudType.Extortion,
                "financial_fraud" => DetectIntelligenceResultDescriptionOneOf1FraudType.FinancialFraud,
                "impersonation" => DetectIntelligenceResultDescriptionOneOf1FraudType.Impersonation,
                "insurance_fraud" => DetectIntelligenceResultDescriptionOneOf1FraudType.InsuranceFraud,
                "none" => DetectIntelligenceResultDescriptionOneOf1FraudType.None,
                "other" => DetectIntelligenceResultDescriptionOneOf1FraudType.Other,
                "political_manipulation" => DetectIntelligenceResultDescriptionOneOf1FraudType.PoliticalManipulation,
                "romance_scam" => DetectIntelligenceResultDescriptionOneOf1FraudType.RomanceScam,
                "synthetic_media_fraud" => DetectIntelligenceResultDescriptionOneOf1FraudType.SyntheticMediaFraud,
                "tech_support_scam" => DetectIntelligenceResultDescriptionOneOf1FraudType.TechSupportScam,
                "vishing" => DetectIntelligenceResultDescriptionOneOf1FraudType.Vishing,
                _ => null,
            };
        }
    }
}
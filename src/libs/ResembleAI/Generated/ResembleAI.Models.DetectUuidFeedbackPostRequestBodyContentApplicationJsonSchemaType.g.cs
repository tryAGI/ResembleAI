
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// What the verdict should have been.<br/>
    ///   - `correct` — the verdict was right.<br/>
    ///   - `should_be_ai_generated` — we said authentic; it is AI-generated.<br/>
    ///   - `should_be_authentic` — we said AI-generated; it is genuine and unaltered.<br/>
    ///   - `should_be_non_ai` — no model generated it, but it may still be edited, spliced, or a human impersonation.<br/>
    ///   - `should_be_neutral` — neither call is right; the media is genuinely ambiguous.<br/>
    ///   - `skipped` — the verdict was wrong, but the reviewer didn't say how.
    /// </summary>
    public enum DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType
    {
        /// <summary>
        ///
        /// </summary>
        Correct,
        /// <summary>
        ///
        /// </summary>
        ShouldBeAiGenerated,
        /// <summary>
        ///
        /// </summary>
        ShouldBeAuthentic,
        /// <summary>
        ///
        /// </summary>
        ShouldBeNeutral,
        /// <summary>
        ///
        /// </summary>
        ShouldBeNonAi,
        /// <summary>
        ///
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType value)
        {
            return value switch
            {
                DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.Correct => "correct",
                DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.ShouldBeAiGenerated => "should_be_ai_generated",
                DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.ShouldBeAuthentic => "should_be_authentic",
                DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.ShouldBeNeutral => "should_be_neutral",
                DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.ShouldBeNonAi => "should_be_non_ai",
                DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "correct" => DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.Correct,
                "should_be_ai_generated" => DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.ShouldBeAiGenerated,
                "should_be_authentic" => DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.ShouldBeAuthentic,
                "should_be_neutral" => DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.ShouldBeNeutral,
                "should_be_non_ai" => DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.ShouldBeNonAi,
                "skipped" => DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType.Skipped,
                _ => null,
            };
        }
    }
}
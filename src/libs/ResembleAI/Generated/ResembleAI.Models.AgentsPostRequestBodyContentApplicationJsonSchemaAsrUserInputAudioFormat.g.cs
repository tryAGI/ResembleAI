
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Default Value: pcm_16000
    /// </summary>
    public enum AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Pcm16000,
        /// <summary>
        /// 
        /// </summary>
        Pcm22050,
        /// <summary>
        /// 
        /// </summary>
        Pcm24000,
        /// <summary>
        /// 
        /// </summary>
        Pcm44100,
        /// <summary>
        /// 
        /// </summary>
        Pcm48000,
        /// <summary>
        /// 
        /// </summary>
        Pcm8000,
        /// <summary>
        /// 
        /// </summary>
        Ulaw8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat value)
        {
            return value switch
            {
                AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm16000 => "pcm_16000",
                AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm22050 => "pcm_22050",
                AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm24000 => "pcm_24000",
                AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm44100 => "pcm_44100",
                AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm48000 => "pcm_48000",
                AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm8000 => "pcm_8000",
                AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm_16000" => AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm16000,
                "pcm_22050" => AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm22050,
                "pcm_24000" => AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm24000,
                "pcm_44100" => AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm44100,
                "pcm_48000" => AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm48000,
                "pcm_8000" => AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Pcm8000,
                "ulaw_8000" => AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}
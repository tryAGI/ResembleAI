
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkAudioModelResultModelVersion
    {
        /// <summary>
        /// 
        /// </summary>
        PerthV1,
        /// <summary>
        /// 
        /// </summary>
        PerthV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkAudioModelResultModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkAudioModelResultModelVersion value)
        {
            return value switch
            {
                WatermarkAudioModelResultModelVersion.PerthV1 => "perth_v1",
                WatermarkAudioModelResultModelVersion.PerthV2 => "perth_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkAudioModelResultModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "perth_v1" => WatermarkAudioModelResultModelVersion.PerthV1,
                "perth_v2" => WatermarkAudioModelResultModelVersion.PerthV2,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePhoneNumberRequest
    {
        /// <summary>
        /// E.164 formatted phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_inbound")]
        public bool? SupportsInbound { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_outbound")]
        public bool? SupportsOutbound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProviderJsonConverter))]
        public global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio_account_sid")]
        public string? TwilioAccountSid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio_auth_token")]
        public string? TwilioAuthToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_trunk")]
        public global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaOutboundTrunk? OutboundTrunk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_trunk")]
        public global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaInboundTrunk? InboundTrunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// E.164 formatted phone number
        /// </param>
        /// <param name="label"></param>
        /// <param name="supportsInbound">
        /// Default Value: false
        /// </param>
        /// <param name="supportsOutbound">
        /// Default Value: false
        /// </param>
        /// <param name="provider"></param>
        /// <param name="twilioAccountSid"></param>
        /// <param name="twilioAuthToken"></param>
        /// <param name="outboundTrunk"></param>
        /// <param name="inboundTrunk"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePhoneNumberRequest(
            string phoneNumber,
            string label,
            bool? supportsInbound,
            bool? supportsOutbound,
            global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider? provider,
            string? twilioAccountSid,
            string? twilioAuthToken,
            global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaOutboundTrunk? outboundTrunk,
            global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaInboundTrunk? inboundTrunk)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.SupportsInbound = supportsInbound;
            this.SupportsOutbound = supportsOutbound;
            this.Provider = provider;
            this.TwilioAccountSid = twilioAccountSid;
            this.TwilioAuthToken = twilioAuthToken;
            this.OutboundTrunk = outboundTrunk;
            this.InboundTrunk = inboundTrunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneNumberRequest" /> class.
        /// </summary>
        public CreatePhoneNumberRequest()
        {
        }

    }
}
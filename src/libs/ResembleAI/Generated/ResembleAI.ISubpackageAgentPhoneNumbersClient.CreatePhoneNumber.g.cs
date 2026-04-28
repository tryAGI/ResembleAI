#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentPhoneNumbersClient
    {
        /// <summary>
        /// Create agent phone number<br/>
        /// Create a new agent phone number
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentPhoneNumbersCreatePhoneNumberResponse200> CreatePhoneNumberAsync(

            global::ResembleAI.CreatePhoneNumberRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent phone number<br/>
        /// Create a new agent phone number
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentPhoneNumbersCreatePhoneNumberResponse200> CreatePhoneNumberAsync(
            string phoneNumber,
            string label,
            bool? supportsInbound = default,
            bool? supportsOutbound = default,
            global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider? provider = default,
            string? twilioAccountSid = default,
            string? twilioAuthToken = default,
            global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaOutboundTrunk? outboundTrunk = default,
            global::ResembleAI.PhoneNumbersPostRequestBodyContentApplicationJsonSchemaInboundTrunk? inboundTrunk = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
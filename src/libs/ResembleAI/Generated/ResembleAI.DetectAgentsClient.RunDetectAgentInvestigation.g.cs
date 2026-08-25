
#nullable enable

namespace ResembleAI
{
    public partial class DetectAgentsClient
    {

        private static readonly global::ResembleAI.AutoSDKServer[] s_RunDetectAgentInvestigationServers = new global::ResembleAI.AutoSDKServer[]
        {            new global::ResembleAI.AutoSDKServer(
                id: "https-app-resemble-ai-api-v2",
                name: "app.resemble.ai api v2",
                url: "https://app.resemble.ai/api/v2",
                description: ""),
        };


        private static readonly global::ResembleAI.EndPointSecurityRequirement s_RunDetectAgentInvestigationSecurityRequirement0 =
            new global::ResembleAI.EndPointSecurityRequirement
            {
                Authorizations = new global::ResembleAI.EndPointAuthorizationRequirement[]
                {                    new global::ResembleAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::ResembleAI.EndPointSecurityRequirement[] s_RunDetectAgentInvestigationSecurityRequirements =
            new global::ResembleAI.EndPointSecurityRequirement[]
            {                s_RunDetectAgentInvestigationSecurityRequirement0,
            };
        partial void PrepareRunDetectAgentInvestigationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string uuid,
            global::ResembleAI.RunDetectAgentInvestigationRequest request);
        partial void PrepareRunDetectAgentInvestigationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string uuid,
            global::ResembleAI.RunDetectAgentInvestigationRequest request);
        partial void ProcessRunDetectAgentInvestigationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRunDetectAgentInvestigationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Run investigation<br/>
        /// Run a managed Detect Agent against uploaded media or a public URL.<br/>
        /// The response is a live Server-Sent Events stream. The first `run_started`<br/>
        /// event contains the persisted run identifier.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> RunDetectAgentInvestigationAsync(
            string uuid,

            global::ResembleAI.RunDetectAgentInvestigationRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await RunDetectAgentInvestigationAsResponseAsync(
                uuid: uuid,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Run investigation<br/>
        /// Run a managed Detect Agent against uploaded media or a public URL.<br/>
        /// The response is a live Server-Sent Events stream. The first `run_started`<br/>
        /// event contains the persisted run identifier.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<string>> RunDetectAgentInvestigationAsResponseAsync(
            string uuid,

            global::ResembleAI.RunDetectAgentInvestigationRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRunDetectAgentInvestigationArguments(
                httpClient: HttpClient,
                uuid: ref uuid,
                request: request);


            var __authorizations = global::ResembleAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RunDetectAgentInvestigationSecurityRequirements,
                operationName: "RunDetectAgentInvestigationAsync");

            using var __timeoutCancellationTokenSource = global::ResembleAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::ResembleAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::ResembleAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::ResembleAI.PathBuilder(
                                path: $"/agents/{uuid}/run",
                                baseUri: ResolveBaseUri(
                                servers: s_RunDetectAgentInvestigationServers,
                                defaultBaseUrl: "https://app.resemble.ai/api/v2"));
                            var __path = __pathBuilder.ToString();
                __path = global::ResembleAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.File != default)
                            {

                                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                                __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Filename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentFile,
                                    name: "\"file\"",
                                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                                if (__contentFile.Headers.ContentDisposition != null)
                                {
                                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.Url != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Url ?? string.Empty),
                                    name: "\"url\"");

                            }
                            if (request.Query != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Query ?? string.Empty),
                                    name: "\"query\"");

                            }
                            if (request.Evidence != default)
                            {

                                for (var __iEvidence = 0; __iEvidence < request.Evidence.Count; __iEvidence++)
                                {
                                    var __contentEvidence = new global::System.Net.Http.ByteArrayContent(request.Evidence[__iEvidence]);
                                __contentEvidence.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                                    __httpRequestContent.Add(
                                        content: __contentEvidence,
                                        name: "\"evidence[]\"",
                                        fileName: $"\"file{__iEvidence}.bin\"");
                                    if (__contentEvidence.Headers.ContentDisposition != null)
                                    {
                                        __contentEvidence.Headers.ContentDisposition.FileNameStar = null;
                                    }
                                }

                            }
                            if (request.CheckUrls != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.CheckUrls ?? string.Empty),
                                    name: "\"check_urls\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::ResembleAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareRunDetectAgentInvestigationRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    uuid: uuid!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::ResembleAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::ResembleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RunDetectAgentInvestigation",
                                methodName: "RunDetectAgentInvestigationAsync",
                                pathTemplate: "$\"/agents/{uuid}/run\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::ResembleAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ResembleAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ResembleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RunDetectAgentInvestigation",
                                methodName: "RunDetectAgentInvestigationAsync",
                                pathTemplate: "$\"/agents/{uuid}/run\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ResembleAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ResembleAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::ResembleAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::ResembleAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ResembleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RunDetectAgentInvestigation",
                                methodName: "RunDetectAgentInvestigationAsync",
                                pathTemplate: "$\"/agents/{uuid}/run\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ResembleAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessRunDetectAgentInvestigationResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ResembleAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ResembleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RunDetectAgentInvestigation",
                                methodName: "RunDetectAgentInvestigationAsync",
                                pathTemplate: "$\"/agents/{uuid}/run\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ResembleAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ResembleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RunDetectAgentInvestigation",
                                methodName: "RunDetectAgentInvestigationAsync",
                                pathTemplate: "$\"/agents/{uuid}/run\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Missing or invalid API key
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::ResembleAI.Error? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::ResembleAI.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::ResembleAI.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::ResembleAI.ApiException<global::ResembleAI.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The investigation is blocked by billing or available credits
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                global::ResembleAI.Error? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::ResembleAI.Error.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::ResembleAI.Error.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::ResembleAI.ApiException<global::ResembleAI.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    responseBody: __content_402,
                                    responseObject: __value_402,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The account does not have Detect Agents access
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::ResembleAI.Error? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::ResembleAI.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::ResembleAI.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::ResembleAI.ApiException<global::ResembleAI.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Detect Agent not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::ResembleAI.Error? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::ResembleAI.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::ResembleAI.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::ResembleAI.ApiException<global::ResembleAI.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Neither `file` nor `url` was provided
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::ResembleAI.Error? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::ResembleAI.Error.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::ResembleAI.Error.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::ResembleAI.ApiException<global::ResembleAI.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Detect Agents service unavailable before streaming begins
                            if ((int)__response.StatusCode == 502)
                            {
                                string? __content_502 = null;
                                global::System.Exception? __exception_502 = null;
                                global::ResembleAI.Error? __value_502 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_502 = global::ResembleAI.Error.FromJson(__content_502, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_502 = global::ResembleAI.Error.FromJson(__content_502, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_502 = __ex;
                                }


                                throw global::ResembleAI.ApiException<global::ResembleAI.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_502 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_502,
                                    responseBody: __content_502,
                                    responseObject: __value_502,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessRunDetectAgentInvestigationResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return new global::ResembleAI.AutoSDKHttpResponse<string>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ResembleAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::ResembleAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return new global::ResembleAI.AutoSDKHttpResponse<string>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ResembleAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::ResembleAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Run investigation<br/>
        /// Run a managed Detect Agent against uploaded media or a public URL.<br/>
        /// The response is a live Server-Sent Events stream. The first `run_started`<br/>
        /// event contains the persisted run identifier.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="file">
        /// Primary media to analyze. Required when `url` is omitted.
        /// </param>
        /// <param name="filename">
        /// Primary media to analyze. Required when `url` is omitted.
        /// </param>
        /// <param name="url">
        /// Public media URL to analyze. Required when `file` is omitted.
        /// </param>
        /// <param name="query">
        /// Question or investigation objective.
        /// </param>
        /// <param name="evidence">
        /// Supporting evidence files. Repeat this field for multiple files.
        /// </param>
        /// <param name="checkUrls">
        /// Additional URLs for the Detect Agent to check.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> RunDetectAgentInvestigationAsync(
            string uuid,
            byte[]? file = default,
            string? filename = default,
            string? url = default,
            string? query = default,
            global::System.Collections.Generic.IList<byte[]>? evidence = default,
            string? checkUrls = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ResembleAI.RunDetectAgentInvestigationRequest
            {
                File = file,
                Filename = filename,
                Url = url,
                Query = query,
                Evidence = evidence,
                CheckUrls = checkUrls,
            };

            return await RunDetectAgentInvestigationAsync(
                uuid: uuid,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
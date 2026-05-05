
#nullable enable

namespace ResembleAI
{
    public partial class SubpackageAudioEnhancementClient
    {

        private static readonly global::ResembleAI.AutoSDKServer[] s_CreateAudioEnhancementServers = new global::ResembleAI.AutoSDKServer[]
        {            new global::ResembleAI.AutoSDKServer(
                id: "https-f-cluster-resemble-ai",
                name: "f.cluster.resemble.ai",
                url: "https://f.cluster.resemble.ai/",
                description: ""),
            new global::ResembleAI.AutoSDKServer(
                id: "https-app-resemble-ai-api-v2",
                name: "app.resemble.ai api v2",
                url: "https://app.resemble.ai/api/v2",
                description: ""),
        };


        private static readonly global::ResembleAI.EndPointSecurityRequirement s_CreateAudioEnhancementSecurityRequirement0 =
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
        private static readonly global::ResembleAI.EndPointSecurityRequirement[] s_CreateAudioEnhancementSecurityRequirements =
            new global::ResembleAI.EndPointSecurityRequirement[]
            {                s_CreateAudioEnhancementSecurityRequirement0,
            };
        partial void PrepareCreateAudioEnhancementArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ResembleAI.CreateAudioEnhancementRequest request);
        partial void PrepareCreateAudioEnhancementRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ResembleAI.CreateAudioEnhancementRequest request);
        partial void ProcessCreateAudioEnhancementResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAudioEnhancementResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202> CreateAudioEnhancementAsync(

            global::ResembleAI.CreateAudioEnhancementRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateAudioEnhancementAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202>> CreateAudioEnhancementAsResponseAsync(

            global::ResembleAI.CreateAudioEnhancementRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateAudioEnhancementArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ResembleAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAudioEnhancementSecurityRequirements,
                operationName: "CreateAudioEnhancementAsync");

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
                                path: "/audio_enhancements",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateAudioEnhancementServers,
                                defaultBaseUrl: "https://f.cluster.resemble.ai/"));
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
                            var __contentAudioFile = new global::System.Net.Http.ByteArrayContent(request.AudioFile ?? global::System.Array.Empty<byte>());
                            __contentAudioFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.AudioFilename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.AudioFilename) ?? string.Empty).ToLowerInvariant() switch
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
                                content: __contentAudioFile,
                                name: "\"audio_file\"",
                                fileName: request.AudioFilename != null ? $"\"{request.AudioFilename}\"" : string.Empty);
                            if (__contentAudioFile.Headers.ContentDisposition != null)
                            {
                                __contentAudioFile.Headers.ContentDisposition.FileNameStar = null;
                            }

                            if (request.EnhancementEngine != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.EnhancementEngine).HasValue ? (request.EnhancementEngine).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"enhancement_engine\"");

                            }
                            if (request.RemoveNoise != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.RemoveNoise, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"remove_noise\"");

                            }
                            if (request.Normalize != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.Normalize, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"normalize\"");

                            }
                            if (request.StudioSound != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.StudioSound, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"studio_sound\"");

                            }
                            if (request.EnhancementLevel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.EnhancementLevel, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"enhancement_level\"");

                            }
                            if (request.LoudnessTargetLevel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.LoudnessTargetLevel, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"loudness_target_level\"");

                            }
                            if (request.LoudnessPeakLimit != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.LoudnessPeakLimit, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"loudness_peak_limit\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::ResembleAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateAudioEnhancementRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                ProcessCreateAudioEnhancementResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ResembleAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ResembleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                            // Bad request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::ResembleAI.CreateAudioEnhancementRequestBadRequestError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::ResembleAI.CreateAudioEnhancementRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::ResembleAI.CreateAudioEnhancementRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::ResembleAI.ApiException<global::ResembleAI.CreateAudioEnhancementRequestBadRequestError>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Forbidden
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::ResembleAI.CreateAudioEnhancementRequestForbiddenError? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::ResembleAI.CreateAudioEnhancementRequestForbiddenError.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::ResembleAI.CreateAudioEnhancementRequestForbiddenError.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::ResembleAI.ApiException<global::ResembleAI.CreateAudioEnhancementRequestForbiddenError>(
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_403,
                                    ResponseObject = __value_403,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
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
                                ProcessCreateAudioEnhancementResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ResembleAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::ResembleAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ResembleAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    throw new global::ResembleAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="enhancementEngine">
        /// Enhancement engine to use. Default is v2.<br/>
        /// Default Value: v2
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enhancementLevel">
        /// Enhancement intensity (0.0 to 1.0). Engine v1 only (legacy).
        /// </param>
        /// <param name="loudnessTargetLevel">
        /// Target loudness in LUFS. Engine v1 only (legacy).<br/>
        /// Default Value: -14
        /// </param>
        /// <param name="loudnessPeakLimit">
        /// Peak limit in dBTP. Engine v1 only (legacy).<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202> CreateAudioEnhancementAsync(
            byte[] audioFile,
            string audioFilename,
            global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine? enhancementEngine = default,
            bool? removeNoise = default,
            bool? normalize = default,
            bool? studioSound = default,
            double? enhancementLevel = default,
            int? loudnessTargetLevel = default,
            int? loudnessPeakLimit = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ResembleAI.CreateAudioEnhancementRequest
            {
                AudioFile = audioFile,
                AudioFilename = audioFilename,
                EnhancementEngine = enhancementEngine,
                RemoveNoise = removeNoise,
                Normalize = normalize,
                StudioSound = studioSound,
                EnhancementLevel = enhancementLevel,
                LoudnessTargetLevel = loudnessTargetLevel,
                LoudnessPeakLimit = loudnessPeakLimit,
            };

            return await CreateAudioEnhancementAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="enhancementEngine">
        /// Enhancement engine to use. Default is v2.<br/>
        /// Default Value: v2
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enhancementLevel">
        /// Enhancement intensity (0.0 to 1.0). Engine v1 only (legacy).
        /// </param>
        /// <param name="loudnessTargetLevel">
        /// Target loudness in LUFS. Engine v1 only (legacy).<br/>
        /// Default Value: -14
        /// </param>
        /// <param name="loudnessPeakLimit">
        /// Peak limit in dBTP. Engine v1 only (legacy).<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202> CreateAudioEnhancementAsync(
            global::System.IO.Stream audioFile,
            string audioFilename,
            global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine? enhancementEngine = default,
            bool? removeNoise = default,
            bool? normalize = default,
            bool? studioSound = default,
            double? enhancementLevel = default,
            int? loudnessTargetLevel = default,
            int? loudnessPeakLimit = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            audioFile = audioFile ?? throw new global::System.ArgumentNullException(nameof(audioFile));
            var request = new global::ResembleAI.CreateAudioEnhancementRequest
            {
                AudioFile = global::System.Array.Empty<byte>(),
                AudioFilename = audioFilename,
                EnhancementEngine = enhancementEngine,
                RemoveNoise = removeNoise,
                Normalize = normalize,
                StudioSound = studioSound,
                EnhancementLevel = enhancementLevel,
                LoudnessTargetLevel = loudnessTargetLevel,
                LoudnessPeakLimit = loudnessPeakLimit,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateAudioEnhancementArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ResembleAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAudioEnhancementSecurityRequirements,
                operationName: "CreateAudioEnhancementAsync");

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
                                path: "/audio_enhancements",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateAudioEnhancementServers,
                                defaultBaseUrl: "https://f.cluster.resemble.ai/"));
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
                            var __contentAudioFile = new global::System.Net.Http.StreamContent(audioFile);
                            __contentAudioFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.AudioFilename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.AudioFilename) ?? string.Empty).ToLowerInvariant() switch
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
                                content: __contentAudioFile,
                                name: "\"audio_file\"",
                                fileName: request.AudioFilename != null ? $"\"{request.AudioFilename}\"" : string.Empty);
                            if (__contentAudioFile.Headers.ContentDisposition != null)
                            {
                                __contentAudioFile.Headers.ContentDisposition.FileNameStar = null;
                            }

                            if (request.EnhancementEngine != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.EnhancementEngine).HasValue ? (request.EnhancementEngine).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"enhancement_engine\"");

                            }
                            if (request.RemoveNoise != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.RemoveNoise, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"remove_noise\"");

                            }
                            if (request.Normalize != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.Normalize, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"normalize\"");

                            }
                            if (request.StudioSound != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.StudioSound, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"studio_sound\"");

                            }
                            if (request.EnhancementLevel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.EnhancementLevel, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"enhancement_level\"");

                            }
                            if (request.LoudnessTargetLevel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.LoudnessTargetLevel, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"loudness_target_level\"");

                            }
                            if (request.LoudnessPeakLimit != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.LoudnessPeakLimit, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"loudness_peak_limit\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::ResembleAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateAudioEnhancementRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                ProcessCreateAudioEnhancementResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ResembleAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ResembleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                            // Bad request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::ResembleAI.CreateAudioEnhancementRequestBadRequestError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::ResembleAI.CreateAudioEnhancementRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::ResembleAI.CreateAudioEnhancementRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::ResembleAI.ApiException<global::ResembleAI.CreateAudioEnhancementRequestBadRequestError>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Forbidden
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::ResembleAI.CreateAudioEnhancementRequestForbiddenError? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::ResembleAI.CreateAudioEnhancementRequestForbiddenError.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::ResembleAI.CreateAudioEnhancementRequestForbiddenError.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::ResembleAI.ApiException<global::ResembleAI.CreateAudioEnhancementRequestForbiddenError>(
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_403,
                                    ResponseObject = __value_403,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
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
                                ProcessCreateAudioEnhancementResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::ResembleAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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

                                    throw new global::ResembleAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="enhancementEngine">
        /// Enhancement engine to use. Default is v2.<br/>
        /// Default Value: v2
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enhancementLevel">
        /// Enhancement intensity (0.0 to 1.0). Engine v1 only (legacy).
        /// </param>
        /// <param name="loudnessTargetLevel">
        /// Target loudness in LUFS. Engine v1 only (legacy).<br/>
        /// Default Value: -14
        /// </param>
        /// <param name="loudnessPeakLimit">
        /// Peak limit in dBTP. Engine v1 only (legacy).<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202>> CreateAudioEnhancementAsResponseAsync(
            global::System.IO.Stream audioFile,
            string audioFilename,
            global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine? enhancementEngine = default,
            bool? removeNoise = default,
            bool? normalize = default,
            bool? studioSound = default,
            double? enhancementLevel = default,
            int? loudnessTargetLevel = default,
            int? loudnessPeakLimit = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            audioFile = audioFile ?? throw new global::System.ArgumentNullException(nameof(audioFile));
            var request = new global::ResembleAI.CreateAudioEnhancementRequest
            {
                AudioFile = global::System.Array.Empty<byte>(),
                AudioFilename = audioFilename,
                EnhancementEngine = enhancementEngine,
                RemoveNoise = removeNoise,
                Normalize = normalize,
                StudioSound = studioSound,
                EnhancementLevel = enhancementLevel,
                LoudnessTargetLevel = loudnessTargetLevel,
                LoudnessPeakLimit = loudnessPeakLimit,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateAudioEnhancementArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ResembleAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAudioEnhancementSecurityRequirements,
                operationName: "CreateAudioEnhancementAsync");

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
                                path: "/audio_enhancements",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateAudioEnhancementServers,
                                defaultBaseUrl: "https://f.cluster.resemble.ai/"));
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
                            var __contentAudioFile = new global::System.Net.Http.StreamContent(audioFile);
                            __contentAudioFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.AudioFilename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.AudioFilename) ?? string.Empty).ToLowerInvariant() switch
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
                                content: __contentAudioFile,
                                name: "\"audio_file\"",
                                fileName: request.AudioFilename != null ? $"\"{request.AudioFilename}\"" : string.Empty);
                            if (__contentAudioFile.Headers.ContentDisposition != null)
                            {
                                __contentAudioFile.Headers.ContentDisposition.FileNameStar = null;
                            }

                            if (request.EnhancementEngine != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.EnhancementEngine).HasValue ? (request.EnhancementEngine).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"enhancement_engine\"");

                            }
                            if (request.RemoveNoise != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.RemoveNoise, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"remove_noise\"");

                            }
                            if (request.Normalize != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.Normalize, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"normalize\"");

                            }
                            if (request.StudioSound != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.StudioSound, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"studio_sound\"");

                            }
                            if (request.EnhancementLevel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.EnhancementLevel, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"enhancement_level\"");

                            }
                            if (request.LoudnessTargetLevel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.LoudnessTargetLevel, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"loudness_target_level\"");

                            }
                            if (request.LoudnessPeakLimit != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.LoudnessPeakLimit, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"loudness_peak_limit\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::ResembleAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateAudioEnhancementRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                ProcessCreateAudioEnhancementResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ResembleAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ResembleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                                operationId: "CreateAudioEnhancement",
                                methodName: "CreateAudioEnhancementAsync",
                                pathTemplate: "\"/audio_enhancements\"",
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
                            // Bad request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::ResembleAI.CreateAudioEnhancementRequestBadRequestError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::ResembleAI.CreateAudioEnhancementRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::ResembleAI.CreateAudioEnhancementRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::ResembleAI.ApiException<global::ResembleAI.CreateAudioEnhancementRequestBadRequestError>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Forbidden
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::ResembleAI.CreateAudioEnhancementRequestForbiddenError? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::ResembleAI.CreateAudioEnhancementRequestForbiddenError.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::ResembleAI.CreateAudioEnhancementRequestForbiddenError.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::ResembleAI.ApiException<global::ResembleAI.CreateAudioEnhancementRequestForbiddenError>(
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_403,
                                    ResponseObject = __value_403,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
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
                                ProcessCreateAudioEnhancementResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ResembleAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::ResembleAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ResembleAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    throw new global::ResembleAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}
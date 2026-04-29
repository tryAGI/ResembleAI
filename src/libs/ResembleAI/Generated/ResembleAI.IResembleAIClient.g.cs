
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IResembleAIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }


        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::ResembleAI.AutoSDKServer> AvailableServers { get; }

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::ResembleAI.AutoSDKServer? SelectedServer { get; set; }

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::ResembleAI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::ResembleAI.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public SubpackageAccountClient SubpackageAccount { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentKnowledgeBaseClient SubpackageAgentKnowledgeBase { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentPhoneNumbersClient SubpackageAgentPhoneNumbers { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentToolsClient SubpackageAgentTools { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentWebhooksClient SubpackageAgentWebhooks { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAgentsClient SubpackageAgents { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAudioEditClient SubpackageAudioEdit { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAudioEnhancementClient SubpackageAudioEnhancement { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAudioSourceTracingClient SubpackageAudioSourceTracing { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageClipsClient SubpackageClips { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageCustomPronunciationsClient SubpackageCustomPronunciations { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageDeepfakeDetectionClient SubpackageDeepfakeDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageDetectIntelligenceClient SubpackageDetectIntelligence { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageDuetsClient SubpackageDuets { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageIdentityClient SubpackageIdentity { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageIntelligenceClient SubpackageIntelligence { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageProjectsClient SubpackageProjects { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageRecordingsClient SubpackageRecordings { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageSecureUploadsClient SubpackageSecureUploads { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageSpeechToTextClient SubpackageSpeechToText { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTermSubstitutionsClient SubpackageTermSubstitutions { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTextToSpeechClient SubpackageTextToSpeech { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageVoiceDesignClient SubpackageVoiceDesign { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageVoiceSettingsPresetsClient SubpackageVoiceSettingsPresets { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageVoicesClient SubpackageVoices { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubpackageWatermarkClient SubpackageWatermark { get; }

    }
}
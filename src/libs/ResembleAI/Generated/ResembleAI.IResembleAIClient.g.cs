
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
        public AccountClient Account { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudioEnhancementClient AudioEnhancement { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudioSourceTracingClient AudioSourceTracing { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClipsClient Clips { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomPronunciationsClient CustomPronunciations { get; }

        /// <summary>
        /// 
        /// </summary>
        public DeepfakeDetectionClient DeepfakeDetection { get; }

        /// <summary>
        /// 
        /// </summary>
        public DetectAgentsClient DetectAgents { get; }

        /// <summary>
        /// 
        /// </summary>
        public DetectIntelligenceClient DetectIntelligence { get; }

        /// <summary>
        /// 
        /// </summary>
        public DuetsClient Duets { get; }

        /// <summary>
        /// 
        /// </summary>
        public IdentityClient Identity { get; }

        /// <summary>
        /// 
        /// </summary>
        public IntelligenceClient Intelligence { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public RecordingsClient Recordings { get; }

        /// <summary>
        /// 
        /// </summary>
        public SecureUploadsClient SecureUploads { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpeechToTextClient SpeechToText { get; }

        /// <summary>
        /// 
        /// </summary>
        public TermSubstitutionsClient TermSubstitutions { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechClient TextToSpeech { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoiceDesignClient VoiceDesign { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoiceSettingsPresetsClient VoiceSettingsPresets { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoicesClient Voices { get; }

        /// <summary>
        /// 
        /// </summary>
        public WatermarkClient Watermark { get; }

    }
}
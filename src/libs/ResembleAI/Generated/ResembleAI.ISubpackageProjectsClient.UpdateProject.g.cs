#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageProjectsClient
    {
        /// <summary>
        /// Update project<br/>
        /// Update a project
        /// </summary>
        /// <param name="projectUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.ProjectsUpdateProjectResponse200> UpdateProjectAsync(
            string projectUuid,

            global::ResembleAI.UpdateProjectRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project<br/>
        /// Update a project
        /// </summary>
        /// <param name="projectUuid"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="isCollaborative"></param>
        /// <param name="isArchived"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.ProjectsUpdateProjectResponse200> UpdateProjectAsync(
            string projectUuid,
            string? name = default,
            string? description = default,
            bool? isCollaborative = default,
            bool? isArchived = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
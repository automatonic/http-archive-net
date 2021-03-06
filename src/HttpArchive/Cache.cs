﻿using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This objects contains info about a request coming from browser cache.
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#cache
    /// </remarks>
    public class Cache : IAllowsComment
    {
        /// <summary>
        /// State of a cache entry before the request. 
        /// </summary>
        /// <remarks>
        /// Leave out this field if the information is not available.
        /// </remarks>
        [JsonPropertyName("beforeRequest")]
        public BeforeRequest? BeforeRequest {get; set;}

        /// <summary>
        /// State of a cache entry after the request.
        /// </summary>
        /// <remarks>
        /// Leave out this field if the information is not available.
        /// </remarks>
        [JsonPropertyName("afterRequest")]
        public AfterRequest? AfterRequest {get; set;}

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}

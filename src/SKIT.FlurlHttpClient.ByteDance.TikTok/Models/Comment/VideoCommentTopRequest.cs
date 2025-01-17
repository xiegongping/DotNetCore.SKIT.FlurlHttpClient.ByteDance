﻿namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/comment/top 接口的请求。</para>
    /// </summary>
    public class VideoCommentTopRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("comment_id")]
        public string CommentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否置顶。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top")]
        [System.Text.Json.Serialization.JsonPropertyName("top")]
        public bool IsTop { get; set; }
    }
}

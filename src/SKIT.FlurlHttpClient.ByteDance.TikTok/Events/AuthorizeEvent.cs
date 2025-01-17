﻿namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Events
{
    /// <summary>
    /// <para>表示 authorize 事件的数据。</para>
    /// <para>REF: https://open.douyin.com/platform/doc/6850452581433608199 </para>
    /// </summary>
    public class AuthorizeEvent : TikTokEvent<AuthorizeEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置授权列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scopes")]
                [System.Text.Json.Serialization.JsonPropertyName("scopes")]
                public string[] ScopeList { get; set; } = default!;
            }
        }
    }
}

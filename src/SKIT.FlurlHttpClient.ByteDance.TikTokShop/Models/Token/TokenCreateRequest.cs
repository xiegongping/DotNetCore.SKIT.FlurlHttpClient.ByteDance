﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /token/create 接口的请求。</para>
    /// </summary>
    public class TokenCreateRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置授权 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权类型。
        /// 默认值：authorization_self。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "authorization_self";

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public int? ShopId { get; set; }

        protected internal override string GetMethod()
        {
            return string.Intern("token.create");
        }
    }
}

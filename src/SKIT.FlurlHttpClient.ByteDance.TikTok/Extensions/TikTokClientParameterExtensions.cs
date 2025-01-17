﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端 JSBridge `sdk.config` 所需的参数。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6850443440044410888 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="jsapiTicket"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJSBridgeConfig(this TikTokClient client, string jsapiTicket, string url)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (jsapiTicket is null) throw new ArgumentNullException(nameof(jsapiTicket));
            if (url is null) throw new ArgumentNullException(nameof(url));

            url = url.Split('#')[0];
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Utilities.MD5Utility.Hash($"jsapi_ticket={jsapiTicket}&nonce_str={nonce}&timestamp={timestamp}&url={url}").ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "client_key", client.Credentials.ClientKey },
                { "timestamp", timestamp },
                { "nonce_str", nonce },
                { "url", url },
                { "signature", sign }
            });
        }

        /// <summary>
        /// <para>生成抖音获取授权临时票据的 URL。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848834666171009035 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="optionalScope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForPlatformOAuthConnect(this TikTokClient client, string? scope = null, string? optionalScope = null, string? redirectUrl = null, string? state = null)
        {
            return new Url("https://open.douyin.com/")
                .AppendPathSegments("platform", "oauth", "connect")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("optionalScope", optionalScope)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .ToString();
        }

        /// <summary>
        /// <para>生成头条获取授权临时票据的 URL。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848834851366275076 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForOAuthAuthorize(this TikTokClient client, string? scope = null, string? redirectUrl = null, string? state = null)
        {
            return new Url("https://open.snssdk.com/")
                .AppendPathSegments("oauth", "authorize")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .ToString();
        }

        /// <summary>
        /// <para>生成抖音获取静默授权临时票据的 URL。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848834666170959883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForOAuthAuthorizeV2(this TikTokClient client, string? scope = null, string? redirectUrl = null, string? state = null)
        {
            return new Url("https://open.snssdk.com/")
                .AppendPathSegments("oauth", "authorize", "v2")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .ToString();
        }

        /// <summary>
        /// <para>生成西瓜获取授权临时票据的 URL。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6852243568438822925 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="optionalScope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForOAuthConnect(this TikTokClient client, string? scope = null, string? optionalScope = null, string? redirectUrl = null, string? state = null)
        {
            return new Url("https://open-api.ixigua.com/")
                .AppendPathSegments("oauth", "connect")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("optionalScope", optionalScope)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .ToString();
        }
    }
}

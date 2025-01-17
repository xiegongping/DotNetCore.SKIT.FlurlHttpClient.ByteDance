﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOICouponExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/coupon/sync 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6985920247903701005 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICouponSyncResponse> ExecutePOICouponSyncAsync(this TikTokClient client, Models.POICouponSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "coupon", "sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICouponSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/v2/coupon/sync/coupon_available 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6985920590397966372 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POICouponSyncCouponAvailableResponse> ExecutePOICouponSyncCouponAvailableAsync(this TikTokClient client, Models.POICouponSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "v2", "coupon", "sync", "coupon_available")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POICouponSyncCouponAvailableResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}

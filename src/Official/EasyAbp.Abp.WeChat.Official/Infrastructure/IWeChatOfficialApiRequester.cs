using System.Net.Http;
using System.Threading.Tasks;
using EasyAbp.Abp.WeChat.Official.Infrastructure.Models;

namespace EasyAbp.Abp.WeChat.Official.Infrastructure
{
    public interface IWeChatOfficialApiRequester
    {
        Task<string> RequestAsync(string targetUrl,
            HttpMethod method,
            IOfficialRequest officialRequest = null,
            bool withAccessToken = true, HttpContent httpContent = null);

        Task<TResponse> RequestAsync<TResponse>(string targetUrl,
            HttpMethod method,
            IOfficialRequest officialRequest = null,
            bool withAccessToken = true, HttpContent httpContent = null);
    }
}
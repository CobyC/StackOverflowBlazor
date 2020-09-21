using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorWasmApp.Helpers
{
    public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        IAccessTokenProvider _provider;
        public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
       NavigationManager navigationManager) : base(provider, navigationManager)
        {
            _provider = provider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            AccessTokenResult accessTokenResult = await _provider.RequestAccessToken();

            if (accessTokenResult.TryGetToken(out AccessToken token))
            {
                //add token to request
                if (!string.IsNullOrWhiteSpace(token.Value))
                    request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);
                else
                    throw new HttpRequestException("No Token!!");
            }

            return await base.SendAsync(request, cancellationToken);
        }

    }
}

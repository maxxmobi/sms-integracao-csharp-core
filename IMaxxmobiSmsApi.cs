using System.Threading.Tasks;
using Refit;

namespace SmsCSharpDotNetClient
{
    public interface IMaxxmobiSmsApi
    {
        [Post("/ws/maxxmobi/envios/")]
        Task<EnvioResponse> EnviaMensagensEmLoteAsync([Body]EnvioRequest request);

        [Post("/ws/maxxmobi/fetch/status/")]
        Task<FetchStatusResponse> BuscaStatusNaoLidos([Body]FetchStatusRequest request);

        [Post("/ws/maxxmobi/fetch/retornos/")]
        Task<FetchRetornosResponse> BuscaRetornosNaoLidos([Body]FetchRetornosRequest request);

    }
}


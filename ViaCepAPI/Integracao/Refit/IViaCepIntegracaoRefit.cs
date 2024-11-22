using Refit;
using ViaCepAPI.Integracao.Response;

namespace ViaCepAPI.Integracao.Refit;

public interface IViaCepIntegracaoRefit
{
    [Get("/ws/{cep}/json")]
    Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
}

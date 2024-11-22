using Microsoft.AspNetCore.Http.HttpResults;
using ViaCepAPI.Integracao.Interfaces;
using ViaCepAPI.Integracao.Refit;
using ViaCepAPI.Integracao.Response;

namespace ViaCepAPI.Integracao;

public class ViaCepIntegracao : IViaCepIntegracao
{
    private readonly IViaCepIntegracaoRefit _refit;

    public ViaCepIntegracao(IViaCepIntegracaoRefit refit)
    {
        _refit = refit;
    }
    public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
    {
       var response = await _refit.ObterDadosViaCep(cep);

        if (response != null && response.IsSuccessStatusCode)
        {
            return response.Content;
        }

        return null;
        
    }
}

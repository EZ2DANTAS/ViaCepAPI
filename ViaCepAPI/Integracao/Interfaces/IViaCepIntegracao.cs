using ViaCepAPI.Integracao.Response;

namespace ViaCepAPI.Integracao.Interfaces;

public interface IViaCepIntegracao
{
    Task<ViaCepResponse> ObterDadosViaCep(string cep);
}

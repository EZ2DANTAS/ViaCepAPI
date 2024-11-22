using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViaCepAPI.Integracao.Interfaces;
using ViaCepAPI.Integracao.Response;

namespace ViaCepAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CepController : ControllerBase
{
    private readonly IViaCepIntegracao _integracao;

    public CepController(IViaCepIntegracao integracao)
    {
        _integracao = integracao;
    }


    [HttpGet("{cep}")]
    public async Task<ActionResult<ViaCepResponse>> ListarDadosEndereco(string cep)
    {
        var result = await _integracao.ObterDadosViaCep(cep);

        if (result is null)
        {
            BadRequest("Cep não encotrado");
        }

        return Ok(result);
    }
    
}

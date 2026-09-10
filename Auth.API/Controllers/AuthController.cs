using Microsoft.AspNetCore.Mvc;

namespace Auth.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    // TODO (passo 3): migrar aqui a lógica que hoje está no AuthController
    // do Marketplace.API - login, geração de token via TokenService.

    // TODO (passo 5): criar um endpoint tipo GET /api/auth/validate
    // que o Products.API vai chamar via HttpClient pra confirmar
    // se um token recebido é válido. Pensa: o que esse endpoint
    // precisa receber, e o que ele deve devolver pro Products.API
    // conseguir confiar (ou não) na requisição?
}

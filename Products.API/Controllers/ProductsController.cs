using Microsoft.AspNetCore.Mvc;

namespace Products.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    // TODO (passo 3): migrar aqui a lógica do ProductController atual
    // (POST/GET/DELETE), usando o repositório e o DbContext deste projeto.

    // TODO (passo 5): antes de executar qualquer ação, este controller
    // (ou um middleware/filtro) precisa checar o token com o Auth.API
    // usando o HttpClient configurado no Program.cs.
    // Pergunta pra pensar: essa validação deveria ficar dentro de cada
    // método do controller, ou em algum lugar mais centralizado
    // (tipo um middleware ou um ActionFilter)? Isso lembra algo que
    // você já viu no pipeline de middleware do seu Marketplace.API?
}

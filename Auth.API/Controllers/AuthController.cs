using System.Collections.Concurrent;
using Microsoft.AspNetCore.Mvc;

namespace Auth.API.Controllers;

public record LoginRequest(string Email, string Password);

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    // Temporário: usuários em memória no lugar do banco
    private static readonly ConcurrentDictionary<string, string> Users = new();

    [HttpPost("register")]
    public IActionResult Register(LoginRequest request)
    {
        if (!Users.TryAdd(request.Email, request.Password))
            return Conflict("E-mail já cadastrado.");

        return Ok(new { request.Email });
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        if (!Users.TryGetValue(request.Email, out var senha) || senha != request.Password)
            return Unauthorized("Credenciais inválidas.");

        // Placeholder: aqui entrará o JWT de verdade (passo 3 do seu roteiro)
        return Ok(new { token = Guid.NewGuid().ToString() });
    }
}
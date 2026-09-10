var builder = WebApplication.CreateBuilder(args);

// TODO (passo 3): registrar aqui o DbContext do Auth.API (o seu próprio,
// separado do Products.API - nada de dividir DbContext entre os dois).

// TODO (passo 3): registrar autenticação JWT e Swagger, igual você já fez
// no Marketplace.API - mas cuidado: aqui é ESTE serviço quem EMITE o token,
// então essa parte não muda muito do que você já tem.

builder.Services.AddControllers();

var app = builder.Build();

// Endpoint de sanity-check, só para confirmar que o serviço está de pé.
// Pode remover quando o AuthController estiver pronto.
app.MapGet("/", () => "Auth.API em funcionamento!");

app.MapControllers();

app.Run("http://localhost:5245");

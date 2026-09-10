var builder = WebApplication.CreateBuilder(args);

// TODO (passo 3): registrar aqui o DbContext do Products.API - seu próprio
// banco, só com as tabelas de produto.

// TODO (passo 5): registrar um HttpClient nomeado (ou tipado) apontando
// pra base URL do Auth.API (http://localhost:5245). Pesquise sobre
// builder.Services.AddHttpClient() antes de implementar - é o ponto
// central desse exercício.

builder.Services.AddControllers();

var app = builder.Build();

// Endpoint de sanity-check. Remova quando o ProductsController estiver pronto.
app.MapGet("/", () => "Products.API no ar");

app.MapControllers();

app.Run("http://localhost:5250");

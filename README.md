# Esqueleto: Marketplace em microsserviços

Estrutura mínima com dois projetos que já sobem e respondem, mas sem
nenhuma lógica de negócio. Cada TODO no código está numerado de acordo
com o passo do roteiro que discutimos no chat.

## Como testar que a casca funciona

Em dois terminais separados:

```bash
cd Auth.API && dotnet run
```

```bash
cd Products.API && dotnet run
```

Acesse `http://localhost:5245` e `http://localhost:5250` - cada um deve
responder com uma mensagem simples confirmando que está no ar.

## Ordem sugerida de trabalho

1. Confirme que os dois sobem juntos, em portas diferentes, sem conflito.
2. Adicione os pacotes NuGet indicados nos comentários de cada `.csproj`.
3. Migre a lógica de domínio (Auth primeiro, depois Products) - copie do
   seu Marketplace.API original, adaptando os namespaces.
4. Configure os bancos separados e gere as migrations de cada projeto.
5. Implemente a chamada HTTP do Products.API para o Auth.API.
6. Rode os dois e teste o fluxo de ponta a ponta pelo Swagger.

Não avance pro próximo passo sem testar o atual - é assim que os erros
aparecem um de cada vez, em vez de todos juntos no final.

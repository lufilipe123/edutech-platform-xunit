# EduTechPlatform

Solução .NET para regras acadêmicas e financeiras, organizada em `EduTechPlatform.App` e `EduTechPlatform.Tests`.

## Requisitos

- .NET 10 SDK

## Serviços

- **NotaDesempenhoService:** calcula a média ponderada e a situação acadêmica.
- **FrequenciaService:** calcula a presença e verifica o mínimo de 75%.
- **MatriculaFinanceiraService:** calcula mensalidades e valida a rematrícula.

## Executar

Na raiz do repositório:

```bash
dotnet restore
dotnet build
dotnet test
```

## Testes

As três suítes usam xUnit. `[Theory]` com `[InlineData]` executa cada conjunto de dados como um cenário separado, cobrindo as regras dos serviços.

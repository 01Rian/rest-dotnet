# Pizza REST API

Um projeto de API REST para gerenciar uma coleção de pizzas, construído com .NET 8.0 Minimal API.

## Descrição

Este projeto é uma aplicação RESTful que permite a gestão completa de um catálogo de pizzas, fornecendo endpoints para listar, buscar, adicionar, atualizar e excluir pizzas.

## Tecnologias Utilizadas

- .NET 8.0
- ASP.NET Core Minimal API
- Swagger/OpenAPI
- CORS

## Estrutura do Projeto

```
rest-dotnet/
├── Program.cs             # Ponto de entrada da aplicação e configuração da API
├── appsettings.json       # Configurações da aplicação
├── src/
│   ├── Models/            # Definições de modelo
│   │   └── Pizza.cs       # Modelo de dados Pizza
│   └── Repositories/      # Camada de acesso a dados
│       └── PizzaRepository.cs # Repositório para operações CRUD
```

## Requisitos

- .NET 8.0 SDK
- Visual Studio 2022 ou Visual Studio Code

## Como Executar

1. Clone este repositório:
```bash
git clone https://github.com/01Rian/rest-dotnet.git
cd rest-dotnet
```

2. Restaure as dependências e execute o projeto:
```bash
dotnet restore
dotnet run
```

3. A API estará disponível em:
   - http://localhost:port
   - Swagger UI: https://localhost:port/swagger

## Endpoints da API

| Método | Endpoint | Descrição |
|--------|----------|-----------|
| GET    | /api/pizzas | Retorna todas as pizzas |
| GET    | /api/pizzas/{id} | Retorna uma pizza específica pelo ID |
| POST   | /api/pizzas | Cria uma nova pizza |
| PUT    | /api/pizzas | Atualiza uma pizza existente |
| DELETE | /api/pizzas/{id} | Remove uma pizza pelo ID |

## Exemplo de Uso

### Listar Todas as Pizzas

```http
GET /api/pizzas
```

### Obter Pizza por ID

```http
GET /api/pizzas/1
```

### Criar Nova Pizza

```http
POST /api/pizzas
Content-Type: application/json

{
  "id": 1,
  "name": "Margherita"
}
```

### Atualizar Pizza

```http
PUT /api/pizzas
Content-Type: application/json

{
  "id": 1,
  "name": "Margherita Especial"
}
```

### Excluir Pizza

```http
DELETE /api/pizzas/1
```
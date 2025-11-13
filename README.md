# 🍔 ChopeeBurgerAPI

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-blueviolet?style=for-the-badge&logo=dotnet" />
  <img src="https://img.shields.io/badge/C%23-Developer-239120?style=for-the-badge&logo=csharp" />
  <img src="https://img.shields.io/badge/MySQL-Database-4479A1?style=for-the-badge&logo=mysql&logoColor=white" />
  <img src="https://img.shields.io/badge/EF%20Core-Migrations-success?style=for-the-badge&logo=entity-framework" />
  <img src="https://img.shields.io/badge/Swagger-API%20Docs-brightgreen?style=for-the-badge&logo=swagger" />
  <img src="https://img.shields.io/badge/Status-Didático%20%2F%20Acadêmico-yellow?style=for-the-badge" />
</p>

API REST desenvolvida em **.NET 8** como projeto **didático** da disciplina  
**Arquitetura de Software e Desenvolvimento Fullstack**.

O objetivo **não** é entregar uma aplicação comercial, mas sim demonstrar:

- Organização de backend em camadas
- Aplicação de conceito de **Repositories**, **Services**, **DTOs** e **Entities**
- Versionamento de banco com **EF Core Migrations**
- Integração simples com **MySQL**
- Boas práticas de arquitetura por responsabilidades

Este repositório serve como **exemplo estruturado** para fins educacionais e portfólio.

---

## 🧱 Tecnologias Utilizadas

- **.NET 8**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **MySQL**
- **Migrations** para versionamento do banco
- **C#**
- Injeção de Dependência nativa do ASP.NET

---

## 📂 Estrutura do Projeto

```bash
ChopeeBurgerAPI
├── Controllers
│   ├── ClientController.cs
│   ├── ProductController.cs
│   └── SaleController.cs
├── Data
│   ├── Context
│   └── Repositories
├── DTOs
│   ├── Filters
│   ├── CreateProductDTO.cs
│   └── CreateSaleDto.cs
├── Entities
│   ├── Client.cs
│   ├── EntityBase.cs
│   ├── Product.cs
│   └── Sale.cs
├── Helpers
│   └── Paginator.cs
├── Interfaces
│   ├── Repository
│   │   ├── IClientRepository.cs
│   │   ├── IProductRepository.cs
│   │   └── ISaleRepository.cs
│   └── IServices
│       ├── IClientService.cs
│       ├── IProductService.cs
│       └── ISaleService.cs
├── Migrations
├── Services
│   ├── ClientService.cs
│   ├── ProductService.cs
│   └── SaleService.cs
├── appsettings.json
├── ChopeeBurgerAPI.http
└── Program.cs

🔍 Sobre a Arquitetura
Entities
Modelos de domínio (Client, Product, Sale), todos herdando de EntityBase.
DTOs
Usados para controlar entrada/saída:
CreateProductDTO
CreateSaleDto
Filtros de paginação e busca
Repositories
Acesso a dados usando Entity Framework Core + MySQL.
Services
Camada intermediária responsável pela regra de negócio.
Controllers
Comportamento exposto via HTTP.
Migrations
Incluídas propositalmente para demonstrar versionamento do banco e evolução de modelo.

❗ A API não representa um sistema completo de produção. O foco é demonstrar boas práticas de arquitetura e organização de código.

🔌 Banco de Dados (MySQL)

A API utiliza MySQL devido à facilidade de setup para fins didáticos.

Exemplo de connection string em appsettings.json:
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=chopee_burger;user=root;password=suasenha;"
}

🚀 Como Executar
1. Restaurar pacotes
dotnet restore

2. Aplicar as migrations ao banco MySQL
dotnet ef database update

3. Rodar o projeto
dotnet run

🎓 Contexto Acadêmico

Projeto desenvolvido como parte da disciplina:

Arquitetura de Software e Desenvolvimento Fullstack
Professor: William Pires de Castro

Objetivo: demonstrar estrutura de API em .NET 8 com boas práticas e versionamento de banco, mantendo o escopo simples e totalmente educacional.

🧩 Status do Projeto

 Estrutura inicial

 MySQL + Migrations

 - [x] CRUD básico de Client/Product/Sale
 - [x] Paginação demonstrativa
 - [x] Swagger
 - [ ] Testes unitários (em aberto)

👨‍💻 Autor

William Pires de Castro  
Professor • Developer • Admirador oficial de coisas que fazem bip-bop  
🦇 Kisses and Bats 4 Everyone 🦇



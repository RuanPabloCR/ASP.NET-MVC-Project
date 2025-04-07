# ASP.NET-MVC-Project

Este é um projeto desenvolvido em C# utilizando o framework ASP.NET Core com o padrão de design MVC (Model-View-Controller). O objetivo do projeto é gerenciar vendas, vendedores e departamentos, fornecendo funcionalidades como criação, edição, exclusão e visualização de registros.

## Funcionalidades

- **Gerenciamento de Vendedores**:
  - Listagem de vendedores.
  - Criação de novos vendedores.
  - Edição de informações de vendedores.
  - Exclusão de vendedores.
  - Visualização de detalhes de vendedores.

- **Gerenciamento de Departamentos**:
  - Listagem de departamentos.
  - Criação de novos departamentos.
  - Edição de informações de departamentos.
  - Exclusão de departamentos.

- **Registros de Vendas**:
  - Pesquisa simples de vendas por intervalo de datas.
  - Pesquisa agrupada de vendas por departamento.
  - Criação de novos registros de vendas.

## Tecnologias Utilizadas

- **Backend**:
  - ASP.NET Core 8.0
  - Entity Framework Core
  - MySQL (via Pomelo.EntityFrameworkCore.MySql)

- **Frontend**:
  - Bootstrap
  - jQuery

- **Outras Ferramentas**:
  - Migrations para controle de banco de dados.
  - Serviços para lógica de negócios.
  - Validação de formulários com jQuery Validation.

## Estrutura do Projeto

A estrutura do projeto segue o padrão MVC:

- **Controllers**: Contém os controladores responsáveis por gerenciar as requisições e respostas.
- **Models**: Contém as classes que representam as entidades do domínio, como `Seller`, `Departament` e `SalesRecord`.
- **Views**: Contém as páginas HTML renderizadas para o usuário.
- **Services**: Contém a lógica de negócios e acesso a dados.

## Configuração do Ambiente

1. Certifique-se de ter o .NET SDK 8.0 ou superior instalado.
2. Configure a string de conexão no arquivo `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "SalesWebMVCContext": "Server=localhost;User Id=seu_usuario;Password=sua_senha;Database=saleswebmvcappdb"
   }

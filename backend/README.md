## No Backend foi desenvolvida uma API REST utilizando a arquitetura DDD separando em projetos distintos sendo eles:

```
BookManager.Domain
BookManager.Infra
BookManager.Service
BookManager.API
```

**_Outros padrões utilizados foram TDD e Injeção de Dependências_**

```
BookManager.Mock
BookManager.UnitTests

```

Requisitos para rodar a aplicação:

- .NET Core 2.2
- PostgreSQL

### O acesso ao banco de dados `Postgres` foi utilizando o EF Core

A string de conexão com o banco é essa aqui:
<br/>
`User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=books;Pooling=true;`

Para rodar as Migrations utilize os seguintes comandos:

```sh
cd backend/BookManager.WebAPI/
dotnet ef database update

```

Agora para rodar os testes automatizados utilize os seguintes comandos:

```sh
cd backend/BookManager.UnitTests/
dotnet test

```

Bom, Depois de tudo configurado, vamos rodar a API:

```sh
cd backend/BookManager.WebAPI/
dotnet run

```

Se tudo deu certo a API vai estar disponivel no endereço: http://localhost:5000

Endponts:

```
GET POST - /api/books
GET POST - /api/books/q
PUT DELETE - /api/books/{id}

GET - /api/authors
GET - /api/genres
GET - /api/publishers
```

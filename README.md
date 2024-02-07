# Projeto CRUD com SQL Server, ASP.NET e Entity Framework

→ Projeto de um App CRUD utilizando SQL Server, ASP.NET e Entity Framework para mapeamento objeto-relacional. 

→ Objetivo: Agendamento de clientes para uma barbearia.

## Demonstração

https://github.com/DiasMath/CRUD_ASP_NET_MS-SQL/assets/92406256/1a56c6bd-6412-4373-b3ff-d0ac94d9b931


## Requisitos

→ Para executar este projeto, você precisará dos seguintes requisitos:

  * Visual Studio ou Visual Studio Code (ou qualquer ambiente de desenvolvimento C#);
  
  * .NET 6 SDK (ou versão superior);
  
  * SQL Server instalado e configurado;

  * Pacotes NuGet do Entity Framework Core.


## Configuração

→ Siga estas etapas para configurar o projeto:

1. Clone este repositório em sua máquina local:

    `git clone https://github.com/seu-usuario/minimalapi-sql-server.git`

2. Abra o projeto em seu ambiente de desenvolvimento.

3. Configure a conexão com o banco de dados SQL Server no arquivo appsettings.json.

    `"ConnectionStrings": {
    'DefaultConnection;: "SUA_CONNECTION_STRING_AQUI"
    }`

4. No terminal, navegue até o diretório do projeto e execute as migrações do Entity Framework para criar o banco de dados:

    `dotnet ef database update`


➤ Agora, você está pronto para executar a aplicação! 🥳👍🏻


## Uso da aplicação

→ Esse projeto possui dois principais endpoints:

* **Página Home com Formulário para Adicionar Clientes:** Você pode acessar a página inicial da aplicação, que inclui um formulário para adicionar novos clientes à lista de clientes da barbearia. Preencha os detalhes do cliente e clique em "Enviar" para registrá-los.

* **Página de Listagem de Clientes:** Acesse a página de listagem de clientes para visualizar a lista de clientes cadastrados. Nesta página, você pode realizar operações de edição e exclusão dos dados do cliente, alterando diretamente no banco.

➤ Você pode acessar essas funcionalidades em seu navegador após iniciar a aplicação no Visual Studio.

## Validações


https://github.com/DiasMath/CRUD_ASP_NET_MS-SQL/assets/92406256/1a2b5877-71de-48f3-a582-4386e0428cbc

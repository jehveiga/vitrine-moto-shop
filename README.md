# Blazor Shop

[![NPM](https://img.shields.io/github/license/jehveiga/Blog-api)](https://github.com/jehveiga/vitrine-moto-shop/blob/main/LICENSE)

# Sobre o projeto

Desenvolvimento de uma aplicação Blazor Server com ASP.NET Core. Neste projeto foi desenvolvido por completo uma aplicação CRUD (CREATE, READ, UPDATE e DELETE) de uma vitrine de motos Shop e suas categorias.

Este projeto suporta todas as versões do ASP.NET Core (até a 8.0) e foi utilizado o Visual Studio 2022 para a construção da aplicação final.

O projeto está disponível na versão 8.0 foi realizado a utilização do banco de dados relacional SQL Server e o padrão de repositories para obter e efetuar a persistencia de dados entre a aplicação e o banco, usado o Entity Framework para facilitar a utilização de comunicação entre o banco, foi utilizado boas práticas do SOLID como injeção de dependencia para consumo de serviços e consumo do repositório nas classes do projeto.
Foi utilizado no projeto a criação de migrações para criar o banco e suas tabelas relacionadas usada entre a aplicação, criado serviços de upload de arquivo para separar a organização de suas devidas reponsabilidades no projeto.
Criado também uma classe manipulador de arquivos para controlar a a persistencias do arquivo no caso de update/delete dos arquivos na aplicação.
Criado o updade de imagens no profile do usuário usando a tabela criada pelo Asp.Net do Identity efetuado a criação de uma coluna contendo os bytes do arquivo que foi feito o udate da imagem pelo cliente, no caso dos produtos o update de imagens são salvos arquivos na pasta no servidor.
Para melhor aproveitamento do projeto usado os dois métodos de update um salvando os bytes no banco das imagens outro salvando as imagens no servidor com um nome seguro criado pela aplicação no momento do upload pelo cliente.
Para estilização do projeto foi usado CSS com Bootstrap 5.
Para estrutura das páginas utilizado Html junto com C# usando as páginas .razor.

# Apresentação Blazor - Vitrine Moto Shop

## Vitrine de produtos - visualização dos produtos separados por categoria e visualização dos detalhes individuais
![Apresentacao Blazor Vitrine de Produtos](https://github.com/jehveiga/vitrine-moto-shop/blob/main/assets/apresentacao-projeto.gif)

# Apresentação Blazor - Categorias

## Categorias Moto - Obter, adicionar, editar e deletar categoria 
![Apresentacao Crud Categorias](https://github.com/jehveiga/vitrine-moto-shop/blob/main/assets/apresentacao-categorias.gif)

# Apresentação - Vitrine Motos

## Motos - Obter, adicionar, editar e deletar produtos motos 
![Apresentacao Crud produtos motos](https://github.com/jehveiga/vitrine-moto-shop/blob/main/assets/apresentacao-motos.gif)

# Apresentação - Profile envio de imagem

## Uplaod Imagem - Upload imagem com a tabela do Identity Usuário
![Apresentacao Upload Imagem](https://github.com/jehveiga/vitrine-moto-shop/blob/main/assets/apresentacao-identity.gif)

# Tecnologias Utilizadas

## Back end

- C#

## Outras Tecnologias

- Blazor Server
- Asp.Net Core
- Boostrap 5
- Boostrap Icons
- CSS
- Html
- Entity Framework Core

## Banco de Dados

- SQL Server

# Autor 

Jefferson Veiga

https://www.linkedin.com/in/jefferson-veiga-dev/

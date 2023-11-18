<h1 align="center">:gift: Academia .NET - Amigo Secreto - Windows Forms</h1>

<p align="center">
  <a href="https://learn.microsoft.com/pt-br/dotnet/"><img alt="DotNet 6" src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white&style=for-the-badge" /></a>
  <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/"><img alt="C#" src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge" /></a>
</p>

## :computer: Projeto

Repositório com solução de desafio para gerenciar listas relacionadas a realização de um amigo secreto, este projeto tem como propósito criar a formarção dos pares do amigo secreto. O desafio foi proposto durante a Academia DotNet ministrada pela `Universidade Franciscana - UFN`.

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-desafio-amigo-secreto-wf/blob/master/src/Academia.DotNet.AmigoSecreto.App/Resources/images/screenshot.PNG" /></p>

## :movie_camera: Vídeo de Demonstração

[Projeto Amigo Secreto - YouTube](https://www.youtube.com/watch?v=mQdRrLL0OUI)

## :page_facing_up: Desafio

[Descrição do Desafio](https://github.com/ricardosma/academia_DotNet_5/blob/main/anotacoesAlexandre/aulas.md)

## :scroll: Funcionalidades

Essa aplicação permite ao usuário:

- Cadastrar `Nome` e `Email` dos amigos que vão participar do `Amigo Secreto`.
- Visualizar duas listas: `amigos cadastrados` e `pares dos amigos`.
- Gerar o sorteio aleatório dos pares dos amigos.
- Remover as listas dos amigos cadastrados e dos pares de amigos.

## :white_check_mark: Decisões Técnicas

1. Procurei adaptar o projeto [Amigo Secreto Console](https://github.com/PauloAlves8039/academia-dotnet-desafio-amigo-secreto/tree/master) para uso do `Windows Forms Applications` com o objeto de manter a regra de negócio anterior ajustadas com as necessidades desse projeto, nas classes `Persistencia`, `Comunicacao` e `Utilitario` se concentram a maior parte das alterações do tipo:

- As substituições do  `Console.WriteLine` por `MessageBox` em alguns métodos.
- A criação de novos métodos para um melhor gerenciamento das listas.
- Em alguns métodos já existentes foram necessárias implementações de trechos de código para fazer sentido com a lógica aplicada. 

3. Os arquivos `amigos.csv` e `secretos.csv` estão salvos no projeto na pasta padrão `bin\Debug\net6.0`, optei em manter essa estrutura para futuras implementações caso seja necessário.

4. Procurei manter a divisão dos nomes e emails usando `;` confome instruções na descrição do enunciado. 

5. Fiz a criação de pastas visando uma organização na estrutura do projeto, decidi seguir essas nomeclaturas de acordo com o que foi apresentado pelo professor em aula. As pastas representam as definições de cada uma das classes utilizadas:

- <b>Communications</b>: nesta pasta é armazenada a classe `Comunicacao` que possui métodos responsáveis pela regra de negócio da aplicação.
- <b>Models</b>: essa pasta é responsável por armazenar a classe de modelo `Amigo`, o objetivo é representar a entidade Amigo.
- <b>Data</b>: essa pasta é responsável por definir a classe que atua com a persistência de dados, foi criada a classe `Persistencia` com esse propósito.
- <b>Utils</b>: esta pasta contem a classe `Utilitario`, o seu objetivo é definir métodos auxiliares para as validações das propriedades e outras funcionalidades.

5. Na criação da interface gráfica eu procurei desenvolver algo simples e agradável para o usuário como:

- O uso de uma barra de progresso na inicialização da aplicação, eu adicionei esse componente para dar um aspecto de execução da aplicação.
- Criar o formulário de cadastro do amigo com fácil acesso.
- Adicionar as duas listas no mesmo formulário, a ideia é facilitar a visualização das listas sem que o usuário precise navegar para outra tela.
- O uso de ícones distintos para cada um do botões, o objetivo dessa abordagem foi aplicar uma visualização intuitiva para o usuário identificar cada ação deseja.
- Os formalários também receberam ícones para uma melhor organização em sua estrutura.

6. O uso de `MessageBox` nas validações dos campos e nas ações de manipulação das listas:

- Nos dois campos que realizam o cadastro dos amigos existem algumas validações do tipo, digitar nome com espaçamento e sobrenome, formato de email válido, se algum desses requisitos não forem atendidos será exibida uma `MessageBox` com alguma mensagem respectiva a validação do campo. 
- Utilizei esse recurso na lista dos pares dos amigos secretos para exibir o conteúdo da lista, inicialmente os pares do amigo secreto não são exibidos na inicialização do projeto, é necessário cadastar amigos e solictar no botão `Gerar Amigo Secreto` e vai aparecer uma `MessageBox` perguntando ao usuário se o mesmo desejar visualizar essa informação.
- Para a exclusão das listas tanto a dos amigos quanto a dos pares do amigo secreto também é exibida uma `MessageBox` questionando o usuário com essa ação.

## ✔️ Recursos Utilizados

- ``.NET 6.0``
- ``Windows Forms Applications``
- ``C#``

## :floppy_disk: Clonar Repositório

```bash
git clone https://github.com/PauloAlves8039/academia-dotnet-desafio-amigo-secreto-wf.git
```

## :boy: Author


<a href="https://github.com/PauloAlves8039"><img src="https://avatars.githubusercontent.com/u/57012714?v=4" width=70></a>
[Paulo Alves](https://github.com/PauloAlves8039)



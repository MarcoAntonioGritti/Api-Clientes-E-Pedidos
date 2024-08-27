# 📦 ApiGerenciamentoClientesPedidos

## 📝 Descrição

Este é um projeto de API em C# que implementa uma relação **Um para Muitos** entre as entidades **Clientes** e **Pedidos**. Cada entidade possui seu próprio conjunto de operações CRUD (Create, Read, Update, Delete).

## 🚀 Funcionalidades

- **Clientes**
  - Cadastrar Cliente
  - Procurar Cliente por ID
  - Atualizar Cliente
  - Deletar Cliente

- **Pedidos**
  - Cadastrar Pedido de Cliente
  - Procurar Pedido de Cliente por ID
  - Atualizar Pedido de Cliente
  - Deletar Pedido de Cliente

## 📦 Pacotes Necessários

- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`
- `Swashbuckle.AspNetCore`

## 🔗 Endpoints

| Entidade | Método  | Endpoint                           | Descrição                        |
|----------|---------|------------------------------------|----------------------------------|
| Cliente  | POST    | `/CadastrarCliente`                | Cadastrar um novo cliente        |
| Cliente  | GET     | `/ProcurarClientePorId/{id}`       | Procurar um cliente por ID       |
| Cliente  | PUT     | `/AtualizarCliente/{id}`           | Atualizar um cliente existente   |
| Cliente  | DELETE  | `/DeletarCliente/{id}`             | Deletar um cliente               |
| Pedido   | POST    | `/CadastrarCliente`                | Cadastrar um novo pedido         |
| Pedido   | GET     | `/ProcurarPedidoClientePorId/{id}` | Procurar um pedido por ID        |
| Pedido   | PUT     | `/AtualizarPedidosCliente/{id}`    | Atualizar um pedido existente    |
| Pedido   | DELETE  | `/DeletarPedidosCliente/{id}`      | Deletar um pedido                |

## 🛠️ Como Usar

### Clonando o Repositório

1. Abra seu terminal ou prompt de comando.
2. Execute o comando abaixo para clonar o repositório:
- git clone https://github.com/SeuUsuario/ApiGerenciamentoClientesPedidos.git

## Criando uma Branch
Para não afetar a branch original, você pode criar uma nova branch para fazer suas modificações:

Navegue até o diretório do repositório clonado:
- cd ApiGerenciamentoClientesPedidos

Crie uma nova branch:
-git checkout -b minha-branch

Contribuindo
Este projeto é de código aberto e qualquer um pode usá-lo, modificá-lo e contribuir com melhorias. Sinta-se à vontade para fazer um fork, criar uma branch para suas modificações e enviar um pull request!

📚 Como Usar
Clone o repositório.
Instale os pacotes necessários.
Configure sua conexão com o banco de dados SQL Server.
Execute a aplicação e se divirta!

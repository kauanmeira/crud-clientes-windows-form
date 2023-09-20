using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; // Importe o namespace Dapper
using System.Data;
using System.Data.SqlClient;


namespace CRUD_CLIENTES_WF.Repositorio
{
    public class ClienteRepositorio
    {
        public void Adicionar(Cliente cliente)
        {
            using IDbConnection conexao = new DbConexao().GetConnection();
            conexao.Execute("INSERT INTO CLIENTES (NOME, EMAIL, CPF, ENDERECO, SENHA) VALUES (@nome, @email, @cpf, @endereco, @senha);",
                new
                {
                    nome = cliente.Nome,
                    email = cliente.Email,
                    cpf = cliente.Cpf,
                    endereco = cliente.Endereco,
                    senha = cliente.Senha,
                }); ;
        }

        public void Atualizar(Cliente cliente)
        {
            using IDbConnection conexao = new DbConexao().GetConnection();
            conexao.Execute("UPDATE CLIENTES SET NOME = @nome, EMAIL = @email, CPF = @cpf, ENDERECO = @endereco, SENHA = @senha WHERE CODIGO = @codigo;",
                new
                {
                    nome = cliente.Nome,
                    email = cliente.Email,
                    cpf = cliente.Cpf,
                    endereco = cliente.Endereco,
                    senha = cliente.Senha,

                    codigo = cliente.Codigo,
                }); ;
        }
        public void Deletar(int codigo)
        {
            using IDbConnection conexao = new DbConexao().GetConnection();
            conexao.Execute("DELETE FROM CLIENTES WHERE CODIGO = @codigo;",
                new
                {
                    codigo
                }); ;
        }

        public Cliente BuscarClientePorId(int codigo)
        {
            using IDbConnection conexao = new DbConexao().GetConnection();
            return conexao.QueryFirstOrDefault<Cliente>(@"SELECT * FROM CLIENTES WHERE CODIGO = @codigo",

                new
                {
                    codigo
                });
        }

        public IEnumerable<Cliente> BuscarTodosClientes()
        {
            using IDbConnection conexao = new DbConexao().GetConnection();
            return conexao.Query<Cliente>(@"SELECT * FROM CLIENTES");

               
        }

    }
}

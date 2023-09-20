using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CLIENTES_WF
{
    public class Cliente
    {
        private Cliente() { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Codigo { get; private set; }
        public string? Nome { get; private set; }
        public string? Cpf { get; private set; }
        public string? Email { get; private set; }
        public string? Senha { get; private set; }
        public string? Endereco { get; private set; }
        public Cliente(int codigo, string? nome, string? cpf, string? email, string? senha, string? endereco)
        {
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Endereco = endereco;
        }

        public Cliente(string? nome, string? cpf, string? email, string? senha, string? endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Endereco = endereco;
        }
    }
}

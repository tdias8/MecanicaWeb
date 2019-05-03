using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecanicaWeb.Models
{
    public class Cliente
    {
        

        public int id { get; set; }
        public string nome { get; set; }
        public double cpf { get; set; }
        public double fone { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public DateTime dataDeNascimento { get; set; }
        public string sexo { get; set; }
        public string estadoCivil { get; set; }
        public Boolean ativo { get; set; }
        public ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();

        public Cliente()
        {
        }

        public Cliente(int id, string nome, double cpf, double fone, string email, string endereco, DateTime dataDeNascimento, string sexo, string estadoCivil, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.fone = fone;
            this.email = email;
            this.endereco = endereco;
            this.dataDeNascimento = dataDeNascimento;
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;
            this.ativo = ativo;
        }
    }
}

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

    }
}

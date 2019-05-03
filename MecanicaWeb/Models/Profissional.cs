using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecanicaWeb.Models
{
    public class Profissional
    {
        public int id { get; set; }
        public string nome  { get; set; }
        public double fone { get; set; }
        public string email { get; set; }
        public ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();

        public Profissional()
        {

        }

        public Profissional(int id, string nome, double fone, string email)
        {
            this.id = id;
            this.nome = nome;
            this.fone = fone;
            this.email = email;
        }
    }
}

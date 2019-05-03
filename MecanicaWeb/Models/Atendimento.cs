using MecanicaWeb.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecanicaWeb.Models
{
    public class Atendimento
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public DateTime hora { get; set; }
        //public ICollection<Profissional> Profissionais { get; set; } = new List<Profissional>();
        //public ICollection<Cliente> Clientes { get; set; } = new List <Cliente>();
        public AtendimentoStatus status { get; set; }
        public string descricao { get; set; }

        public Atendimento()
        {

        }

        public Atendimento(int id, DateTime data, DateTime hora, AtendimentoStatus status, string descricao)
        {
            this.id = id;
            this.data = data;
            this.hora = hora;
            this.status = status;
            this.descricao = descricao;
        }
    }
}

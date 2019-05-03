using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecanicaWeb.Models
{
    public class Agenda
    {
        public DateTime data { get; set; }
        public DateTime hora { get; set; }
        public ICollection<Profissional> Profissionais { get; set; } = new List<Profissional>();

        public Agenda()
        {

        }

        public Agenda(DateTime data, DateTime hora)
        {
            this.data = data;
            this.hora = hora;
        }
    }
    
    
}

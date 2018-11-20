using System;
using System.Collections.Generic;

namespace CreateAPI.Models
{
    public partial class Agenda
    {
        public Agenda()
        {
            Contacts = new HashSet<Contacts>();
        }

        public int Id { get; set; }
        public string Propietario { get; set; }

        public ICollection<Contacts> Contacts { get; set; }
    }
}

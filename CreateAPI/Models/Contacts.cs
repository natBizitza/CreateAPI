using System;
using System.Collections.Generic;

namespace CreateAPI.Models
{
    public partial class Contacts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public int? IdAgenda { get; set; }

        public Agenda IdAgendaNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_Management_Application.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string contactFname { get; set; }
        public string ContactLname { get; set; }
        public string contactEmail { get; set; }
        public string contactAddr1 { get; set; }
        public string contactAddr2 { get; set; }
        public string contactCity { get; set; }
        public string contactPostCode { get; set; }

    }
}
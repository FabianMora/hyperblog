using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ApiSqlPlatzi.models
{
    public class Contacts
    {
        [Key]
        public int Identificador { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }

    }
}
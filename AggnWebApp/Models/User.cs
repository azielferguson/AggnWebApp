using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggnWebApp.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
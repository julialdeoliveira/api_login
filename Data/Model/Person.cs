using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Person : BaseModel
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public string Cpf { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

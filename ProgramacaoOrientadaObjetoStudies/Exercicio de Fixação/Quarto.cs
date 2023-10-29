using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores.Exercicio_de_Fixação
{
    class Quarto
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Quarto(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}

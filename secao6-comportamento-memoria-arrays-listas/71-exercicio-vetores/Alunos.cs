using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71_exercicio_vetores
{
    internal class Alunos
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Alunos(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public Alunos() { }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}

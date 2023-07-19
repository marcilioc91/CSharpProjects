using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Aluno
    {
        public string Nome;
        public int NotaA;
        public int NotaB;
        public int NotaC;

        public int NotaTotal()
        {
            return NotaA + NotaB + NotaC;
        }

        public bool Aprovado()
        {
            return NotaTotal() >= 7 ? true : false;
        }

        public int NotaRestante()
        {
            return Aprovado() ? 0 : 60 - NotaTotal();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAluno
{
    internal class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return (nota1 + nota2 + nota3) / 3;
        }
        public bool Aprovado()
        {
            if (NotaFinal() > 5.99){
                return true;
            }
            else { return false; }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 6.0 - NotaFinal();
            }
        }
    }
}

using ExercicioAluno;
using System;
using System.Globalization;

namespace ExercioAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe o nome do Aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Informe as 3 notas do aluno: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            aluno.nota2 = double.Parse(Console.ReadLine());
            aluno.nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: " + aluno.NotaFinal().ToString("F2"));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("Faltou: " + aluno.NotaRestante().ToString("F2"));
            }
        }
    }
}
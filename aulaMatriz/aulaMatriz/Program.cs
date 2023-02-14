using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[5];
            float[,] notas = new float[2, 5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome do " + (i + 1) + "º aluno: ");
                alunos[i] = Console.ReadLine();
            }

            for (int c = 0; c < 5; c++)
            {
                for (int l = 0; l < 2; l++)
                {

                    Console.WriteLine("insira a " + (l + 1) + "ª do aluno " + alunos[c] + ": ");
                    notas[l, c] = float.Parse(Console.ReadLine());

                }
            }



        }
    }
}

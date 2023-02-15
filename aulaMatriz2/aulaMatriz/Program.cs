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
            string[] alunos;// responsável por receber o nome dos alunos pelo usuario
            int qntAluno;// responsável por definir a quantia de cadastros que o usuario desejar
            float[,] notas;// responsável por receber quantas notas cada aluno ira receber
            float media;
            float[] grade;


            Console.Write("Informe a quantidade de alunos: ");// entrada da quantia de alunos que o sistema ira aceitar
            qntAluno = int.Parse(Console.ReadLine());

            notas = new float[2, qntAluno]; // aqui sera feito a delimitação para a quantidade de nota que devera ser inserida 
            alunos = new string[qntAluno];// capacidade do sistema de aceitar o nome dos alunos
            grade = new float[qntAluno];



            for (int c = 0; c < qntAluno; c++)
            {
                Console.Write("Digite o nome do " + (c + 1) + "º aluno: ");
                alunos[c] = Console.ReadLine();

                for (int l = 0; l < 2; l++)
                {
                    Console.Write("insira a " + (l + 1) + "ª nota do aluno " + alunos[c] + ": ");
                    notas[l, c] = float.Parse(Console.ReadLine());

                }


            }


            for (int c = 0; c < qntAluno; c++)
            {
                media = (notas[0, c] + notas[1, c]) / 2;
                grade[c] = media;
                                
            }


            for (int i = 0; i < qntAluno; i++)
            {
                Console.WriteLine("A media do aluno: " + alunos[i] + " é:" +grade[i] +" ");
            }

            Console.ReadKey();

        }
    }
}

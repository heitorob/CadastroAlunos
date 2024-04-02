using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CadastroAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adm = 0, ds = 0, edif = 0, meca = 0;
            string resp = "S";

            while (resp == "S")
            {
                Console.Write("Insira o curso do aluno matriculado" +
                              "\nA - Administração . D - Desenvolvimento de Sistemas . " +
                              "E - Edificações . M - Mecatrônica : ");
                string matri = Console.ReadLine().ToUpper().Substring(0, 1);

                switch (matri)
                {
                    case "A":
                        if (adm < 5)
                        {
                            adm++;
                            Console.WriteLine("--\nAluno cadastrado com sucesso.\nCurso: Administração");
                        }
                        else
                        {
                            Console.WriteLine("Todas as vagas já foram preenchidas.");
                        }
                        break;

                    case "D":
                        if (ds < 5)
                        {
                            ds++;
                            Console.WriteLine("--\nAluno cadastrado com sucesso.\nCurso: Desenvolvimento de Sistemas");
                        }
                        else
                        {
                            Console.WriteLine("Todas as vagas já foram preenchidas.");
                        }
                        break;

                    case "E":
                        if (edif < 5)
                        {
                            edif++;
                            Console.WriteLine("--\nAluno cadastrado com sucesso.\nCurso: Edificações");
                        }
                        else
                        {
                            Console.WriteLine("Todas as vagas já foram preenchidas.");
                        }
                        break;

                    case "M":
                        if (meca < 5)
                        {
                            meca++;
                            Console.WriteLine("--\nAluno cadastrado com sucesso.\nCurso: Mecatrônica");
                        }
                        else
                        {
                            Console.WriteLine("Todas as vagas já foram preenchidas.");
                        }
                        break;

                    default:
                        Console.WriteLine("Código incorreto!!");
                        break;
                }

                Console.WriteLine("--\nVAGAS RESTANTES" +
                                  "\nAdministração: " + (5 - adm) + 
                                  "\nDesenvolvimento de Sistemas: " + (5 - ds) + 
                                  "\nEdificações: " + (5 - edif) + 
                                  "\nMecatrônica: " + (5 - meca));
                Console.Write("--\nDeseja cadastrar outro aluno?\nS - Sim . N - Não : ");
                    resp = Console.ReadLine().ToUpper().Substring(0, 1);
                Console.Clear();
            }
            Console.Write("ALUNOS CADASTRADOS" +
                          "\nAdministração: " + adm +
                          "\nDesenvolvimento de Sistemas: " + ds +
                          "\nEdificações: " + edif +
                          "\nMecatrônica: " + meca +
                          "\n--\nTotal: " + (adm + ds + edif + meca));
            Console.ReadKey();
        }
    }
}

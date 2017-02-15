using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VerifSerasaCon
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter lista = new StreamWriter(@"Retirar.txt");

            string[] ord = File.ReadAllLines("Cancelados.txt");
            string[] log = File.ReadAllLines("Prot.txt");
            int cont = 0;
            List<string> arq = new List<string>();
            List<string> arq2 = new List<string>();


            for (int i = 0; i < ord.Length; i++)
                for (int j = 0; j < log.Length; j++)
                {
                    if (log[j].Length < 500 || ord[i].Length < 15)
                        continue;
                    else
                        if (log[j].Substring(450, 7) == ord[i].Substring(0, 7).Replace(" ", ""))
                        {
                            arq.Add(log[j].Substring(450, 7) + " " + log[j].Substring(260, 8) + " " + log[j].Substring(477, 8));
                        }
                }

            foreach (string linha in arq)
            {
                if (arq2.Contains(linha))
                {
                    continue;
                }
                else
                    arq2.Add(linha);
            }


            string[] arq3 = sorteia(arq2);

            foreach (string linha in arq3)
            {
                lista.WriteLine(linha);
                cont++;
            }

            lista.Close();

            Console.WriteLine("\nTotal a Retirar = " + cont, "Concluído");
            Console.ReadKey();
        }

        public static string[] sorteia(List<string> arq2)
        {
            string[] lista = arq2.ToArray();

            int pos = 0;
            for (int i = 0; i < lista.Count() - 1; )
                if (dataM(lista[pos + 1].Substring(8, 8), lista[pos].Substring(8, 8)))
                {
                    string aux = lista[pos];
                    lista[pos] = lista[pos + 1];
                    lista[pos + 1] = aux;
                    if (pos > 0) pos--;
                }
                else pos = ++i;

            return lista;

        }

        public static bool dataM(string data1, string data2)
        {
            bool menor = false;

            int ano1 = int.Parse(data1.Substring(4, 4));
            int ano2 = int.Parse(data2.Substring(4, 4));
            int mes1 = int.Parse(data1.Substring(2, 2));
            int mes2 = int.Parse(data2.Substring(2, 2));
            int dia1 = int.Parse(data1.Substring(0, 2));
            int dia2 = int.Parse(data2.Substring(0, 2));

            if (ano1 < ano2)
                menor = true;
            else
                if (ano1 == ano2)
                    if (mes1 < mes2)
                        menor = true;
                    else
                        if (mes1 == mes2)
                            if (dia1 < dia2)
                                menor = true;

            return menor;
        }

    }
}

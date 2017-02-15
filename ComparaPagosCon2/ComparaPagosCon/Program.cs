using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace ComparaPagosCon
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] cerinfo = File.ReadAllLines("Cerinfo.txt");
            string[] c = File.ReadAllLines("C.txt");
            string[] v = File.ReadAllLines("V.txt");

            string data = cerinfo[2].Substring(3, 5).Replace("/", "");
            string[] ord = File.ReadAllLines("R0602109." + data.Substring(0, 2) + "0");
            StreamWriter lista = new StreamWriter(@"Arquivos\\PagosCaixa" + data + ".txt");

            int cont = 0;
            List<string> comparador = new List<string>();
            List<string> result = new List<string>();
            List<string> antiComparador = new List<string>();


            for (int i = 0; i < ord.Length; i++)
                if (ord[i].Length > 312 &&
                    ord[i].Substring(18, 9).Equals("141002601") &&
                    !ord[i].Substring(298, 13).Equals("0000000000000"))
                {
                    comparador.Add("1" + ord[i].Substring(63, 6));
                }

            string cancelados = "", devolvidos = "";

            for (int i = 0; i < c.Length; i++)
                if (c[i].Length > 23 &&
                    c[i].Substring(0, 22).Equals("QUANTIDADE DE TITULOS:"))
                {
                    int fim = c[i].Length - 23;
                    cancelados = c[i].Substring(23, fim);
                    break;
                }

            for (int i = 0; i < v.Length; i++)
                if (v[i].Length > 28 &&
                    v[i].Substring(0, 24).Equals("TOTAL GERAL DE TITULOS :"))
                {
                    devolvidos = v[i].Substring(25, 3);
                }






            int faixa3001 = 0,
                faixa3002 = 0,
                faixa3003a = 0,
                faixa3003 = 0,
                faixa3004 = 0,
                faixa3005 = 0,
                faixa3006 = 0;

            for (int i = 0; i < cerinfo.Length; i++)
            {


                if (cerinfo[i].Length < 12)
                    continue;
                else
                {
                    if (cerinfo[i].Substring(0, 1).Equals("1"))
                        antiComparador.Add(cerinfo[i].Substring(0, 7));
                    if (cerinfo[i].Substring(0, 1).Equals("1") && !comparador.Contains(cerinfo[i].Substring(0, 7)))
                    {
                        lista.WriteLine(cerinfo[i]);
                        result.Add(cerinfo[i]);
                        cont++;
                    }
                }
            }


            for (int i = 0; i < cerinfo.Length; i++)
            {
                if (cerinfo[i].Substring(0, 1).Equals("1"))
                {
                    int inicio = 0;
                    int fim = 0;
                    int contSpace = 0;

                    for (int j = cerinfo[i].Length - 1; j >= 0; j--)
                    {
                        if (cerinfo[i].Substring(j, 1).Equals(" "))
                            contSpace++;
                        if (contSpace == 2 && j >= fim)
                            fim = j;
                        if (contSpace == 3)
                        {
                            inicio = j;
                            fim = fim - inicio;
                            break;
                        }
                    }

                    if (double.Parse(cerinfo[i].Substring(inicio, fim)) >= 851.49)
                        faixa3006++;
                    else
                        if (double.Parse(cerinfo[i].Substring(inicio, fim)) >= 426.31)
                            faixa3005++;
                        else
                            if (double.Parse(cerinfo[i].Substring(inicio, fim)) >= 212.77)
                                faixa3004++;
                            else
                                if (double.Parse(cerinfo[i].Substring(inicio, fim)) >= 100.01)
                                    faixa3003++;
                                else
                                    if (double.Parse(cerinfo[i].Substring(inicio, fim)) >= 85.29)
                                        faixa3003a++;
                                    else
                                        if (double.Parse(cerinfo[i].Substring(inicio, fim)) >= 14.21)
                                            faixa3002++;
                                        else
                                            faixa3001++;
                }
            }



            lista.WriteLine();
            lista.WriteLine();
            lista.WriteLine("Total Geral " + (faixa3001 + faixa3002 + faixa3003 + faixa3003a + faixa3004 + faixa3005 + faixa3006));
            lista.WriteLine("Total Bic   " + (faixa3001 + faixa3002 + faixa3003 + faixa3003a + faixa3004 + faixa3005 + faixa3006 - cont));
            lista.WriteLine("Pags Janete " + cont);
            lista.WriteLine("Bic Retorno " + comparador.Count);
            lista.WriteLine();

            if ((faixa3001 + faixa3002 + faixa3003 + faixa3003a + faixa3004 + faixa3005 + faixa3006 - cont) != comparador.Count)
            {
                lista.WriteLine("Lista de Protocolos pagos Nao Baixados");
                for (int i = 0; i < comparador.Count; i++)
                {
                    if (!antiComparador.Contains(comparador[i]))
                        lista.WriteLine(comparador[i]);
                }

            }

            lista.WriteLine();
            lista.WriteLine("CANCELADOS = " + cancelados);
            lista.WriteLine("DEVOLVIDOS = " + devolvidos);


            lista.WriteLine();
            lista.WriteLine("Faixas");
            lista.WriteLine(faixa3001);
            lista.WriteLine(faixa3002);
            lista.WriteLine(faixa3003a);
            lista.WriteLine(faixa3003);
            lista.WriteLine(faixa3004);
            lista.WriteLine(faixa3005);
            lista.WriteLine(faixa3006);



            faixa3001 = 0;
            faixa3002 = 0;
            faixa3003a = 0;
            faixa3003 = 0;
            faixa3004 = 0;
            faixa3005 = 0;
            faixa3006 = 0;


            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].Substring(0, 1).Equals("1"))
                {
                    int inicio = 0;
                    int fim = 0;
                    int contSpace = 0;

                    for (int j = result[i].Length - 1; j >= 0; j--)
                    {
                        if (result[i].Substring(j, 1).Equals(" "))
                            contSpace++;
                        if (contSpace == 2 && j >= fim)
                            fim = j;
                        if (contSpace == 3)
                        {
                            inicio = j;
                            fim = fim - inicio;
                            break;
                        }
                    }

                    if (double.Parse(result[i].Substring(inicio, fim)) >= 851.49)
                        faixa3006++;
                    else
                        if (double.Parse(result[i].Substring(inicio, fim)) >= 426.31)
                            faixa3005++;
                        else
                            if (double.Parse(result[i].Substring(inicio, fim)) >= 212.77)
                                faixa3004++;
                            else
                                if (double.Parse(result[i].Substring(inicio, fim)) >= 100.01)
                                    faixa3003++;
                                else
                                    if (double.Parse(result[i].Substring(inicio, fim)) >= 85.29)
                                        faixa3003a++;
                                    else
                                        if (double.Parse(result[i].Substring(inicio, fim)) >= 14.21)
                                            faixa3002++;
                                        else
                                            faixa3001++;
                }
            }

            lista.WriteLine();
            lista.WriteLine("Faixas");
            lista.WriteLine(faixa3001);
            lista.WriteLine(faixa3002);
            lista.WriteLine(faixa3003a);
            lista.WriteLine(faixa3003);
            lista.WriteLine(faixa3004);
            lista.WriteLine(faixa3005);
            lista.WriteLine(faixa3006);

            lista.Close();

            Process.Start("Arquivos\\PagosCaixa" + data + ".txt");


        }
    }
}

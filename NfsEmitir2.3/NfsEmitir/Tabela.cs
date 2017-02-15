using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace NfsEmitir
{
    class Tabela
    {

        private string[] valorTabela;

        public void inicia(string arquivo)
        {
            if (File.Exists(arquivo))
            {
                string[] tabela = File.ReadAllLines(arquivo);
                valorTabela = tabela;
            }
            else
            {
                MessageBox.Show("Arquivo de Tabela " + arquivo + " Não Encontrado");
                System.Environment.Exit(0);
            }
        }

        private int calculaFaixa(double valor)
        {
            if (valor > 851.48)
                return 7;
            else
                if (valor > 426.30)
                    return 6;
                else
                    if (valor > 212.76)
                        return 5;
                    else
                        if (valor > 100.00)
                            return 4;
                        else
                            if (valor > 85.28)
                                return 3;
                            else
                                if (valor > 14.20)
                                    return 2;
                                else
                                    return 1;

        }

        public double valorProtesto(double valor)
        {
            double resultado = 0;

            switch (calculaFaixa(valor))
            {
                case 1: resultado = double.Parse(valorTabela[0].Substring(17, 8)); break;
                case 2: resultado = double.Parse(valorTabela[1].Substring(17, 8)); break;
                case 3: resultado = double.Parse(valorTabela[2].Substring(17, 8)); break;
                case 4: resultado = double.Parse(valorTabela[3].Substring(17, 8)); break;
                case 5: resultado = double.Parse(valorTabela[4].Substring(17, 8)); break;
                case 6: resultado = double.Parse(valorTabela[5].Substring(17, 8)); break;
                case 7: resultado = double.Parse(valorTabela[6].Substring(17, 8)); break;
            }

            return resultado;
        }

        public double valorDevolucao(double valor)
        {
            double resultado = 0;

            switch (calculaFaixa(valor))
            {
                case 1: resultado = double.Parse(valorTabela[7].Substring(17, 8)); break;
                case 2: resultado = double.Parse(valorTabela[8].Substring(17, 8)); break;
                case 3: resultado = double.Parse(valorTabela[9].Substring(17, 8)); break;
                case 4: resultado = double.Parse(valorTabela[10].Substring(17, 8)); break;
                case 5: resultado = double.Parse(valorTabela[11].Substring(17, 8)); break;
                case 6: resultado = double.Parse(valorTabela[12].Substring(17, 8)); break;
                case 7: resultado = double.Parse(valorTabela[13].Substring(17, 8)); break;
            }

            return resultado;
        }

        public double valorPagamento(double valor)
        {
            double resultado = 0;

            switch (calculaFaixa(valor))
            {
                case 1: resultado = double.Parse(valorTabela[14].Substring(17, 8)); break;
                case 2: resultado = double.Parse(valorTabela[15].Substring(17, 8)); break;
                case 3: resultado = double.Parse(valorTabela[16].Substring(17, 8)); break;
                case 4: resultado = double.Parse(valorTabela[17].Substring(17, 8)); break;
                case 5: resultado = double.Parse(valorTabela[18].Substring(17, 8)); break;
                case 6: resultado = double.Parse(valorTabela[19].Substring(17, 8)); break;
                case 7: resultado = double.Parse(valorTabela[20].Substring(17, 8)); break;
            }

            return resultado;
        }

        public double valorCancelamento()
        {
            return double.Parse(valorTabela[27].Substring(17, 8));
        }

        public double valorBxDistribuicao()
        {
            return double.Parse(valorTabela[23].Substring(17, 8));
        }

        public double valorEdital()
        {
            return double.Parse(valorTabela[21].Substring(17, 8));
        }

        public double valorTxEdital()
        {
            return double.Parse(valorTabela[28].Substring(17, 8));
        }

        public double valorDistribuidor()
        {
            return double.Parse(valorTabela[22].Substring(17, 8));
        }

        public double valorCustaCertidao(int opcao, int informacoes)
        {
            double resultado = 0;
            if (opcao == 0)
                resultado = double.Parse(valorTabela[26].Substring(17, 8));
            else
            {
                resultado = double.Parse(valorTabela[24].Substring(17, 8));
                if (informacoes > 1)
                    resultado += ((informacoes - 1) * double.Parse(valorTabela[25].Substring(17, 8)));

            }

            return resultado;
        }


        public double valorProtestoDeducao(double valor)
        {
            double resultado = 0;

            switch (calculaFaixa(valor))
            {
                case 1: resultado = double.Parse(valorTabela[0].Substring(29, 8)); break;
                case 2: resultado = double.Parse(valorTabela[1].Substring(29, 8)); break;
                case 3: resultado = double.Parse(valorTabela[2].Substring(29, 8)); break;
                case 4: resultado = double.Parse(valorTabela[3].Substring(29, 8)); break;
                case 5: resultado = double.Parse(valorTabela[4].Substring(29, 8)); break;
                case 6: resultado = double.Parse(valorTabela[5].Substring(29, 8)); break;
                case 7: resultado = double.Parse(valorTabela[6].Substring(29, 8)); break;
            }

            return resultado;
        }

        public double valorDevolucaoDeducao(double valor)
        {
            double resultado = 0;

            switch (calculaFaixa(valor))
            {
                case 1: resultado = double.Parse(valorTabela[7].Substring(29, 8)); break;
                case 2: resultado = double.Parse(valorTabela[8].Substring(29, 8)); break;
                case 3: resultado = double.Parse(valorTabela[9].Substring(29, 8)); break;
                case 4: resultado = double.Parse(valorTabela[10].Substring(29, 8)); break;
                case 5: resultado = double.Parse(valorTabela[11].Substring(29, 8)); break;
                case 6: resultado = double.Parse(valorTabela[12].Substring(29, 8)); break;
                case 7: resultado = double.Parse(valorTabela[13].Substring(29, 8)); break;
            }

            return resultado;
        }

        public double valorPagamentoDeducao(double valor)
        {
            double resultado = 0;

            switch (calculaFaixa(valor))
            {
                case 1: resultado = double.Parse(valorTabela[14].Substring(29, 8)); break;
                case 2: resultado = double.Parse(valorTabela[15].Substring(29, 8)); break;
                case 3: resultado = double.Parse(valorTabela[16].Substring(29, 8)); break;
                case 4: resultado = double.Parse(valorTabela[17].Substring(29, 8)); break;
                case 5: resultado = double.Parse(valorTabela[18].Substring(29, 8)); break;
                case 6: resultado = double.Parse(valorTabela[19].Substring(29, 8)); break;
                case 7: resultado = double.Parse(valorTabela[20].Substring(29, 8)); break;
            }

            return resultado;
        }

        public double valorCancelamentoDeducao()
        {
            return double.Parse(valorTabela[27].Substring(29, 8));
        }

        public double valorBxDistribuicaoDeducao()
        {
            return double.Parse(valorTabela[23].Substring(29, 8));
        }

        public double valorEditalDeducao()
        {
            return double.Parse(valorTabela[21].Substring(29, 8));
        }

        public double valorTxEditalDeducao()
        {
            return double.Parse(valorTabela[28].Substring(29, 8));
        }

        public double valorDistribuidorDeducao()
        {
            return double.Parse(valorTabela[22].Substring(29, 8));
        }

        public double valorCustaCertidaoDeducao(int opcao, int informacoes)
        {
            double resultado = 0;
            if (opcao == 0)
                resultado = double.Parse(valorTabela[26].Substring(29, 8));
            else
            {
                resultado = double.Parse(valorTabela[24].Substring(29, 8));
                if (informacoes > 1)
                    resultado += ((informacoes - 1) * double.Parse(valorTabela[25].Substring(29, 8)));

            }

            return resultado;
        }


        public string valorProtestoDeducaoDescricao(double valor)
        {
            string resultado = "";

            switch (calculaFaixa(valor))
            {
                case 1: resultado = valorTabela[0].Substring(39, 38); break;
                case 2: resultado = valorTabela[1].Substring(39, 38); break;
                case 3: resultado = valorTabela[2].Substring(39, 38); break;
                case 4: resultado = valorTabela[3].Substring(39, 38); break;
                case 5: resultado = valorTabela[4].Substring(39, 38); break;
                case 6: resultado = valorTabela[5].Substring(39, 38); break;
                case 7: resultado = valorTabela[6].Substring(39, 38); break;
            }

            return resultado;
        }

        public string valorDevolucaoDeducaoDescricao(double valor)
        {
            string resultado = "";

            switch (calculaFaixa(valor))
            {
                case 1: resultado = valorTabela[7].Substring(39, 38); break;
                case 2: resultado = valorTabela[8].Substring(39, 38); break;
                case 3: resultado = valorTabela[9].Substring(39, 38); break;
                case 4: resultado = valorTabela[10].Substring(39, 38); break;
                case 5: resultado = valorTabela[11].Substring(39, 38); break;
                case 6: resultado = valorTabela[12].Substring(39, 38); break;
                case 7: resultado = valorTabela[13].Substring(39, 38); break;
            }

            return resultado;
        }

        public string valorPagamentoDeducaoDescricao(double valor)
        {
            string resultado = "";

            switch (calculaFaixa(valor))
            {
                case 1: resultado = valorTabela[14].Substring(39, 38); break;
                case 2: resultado = valorTabela[15].Substring(39, 38); break;
                case 3: resultado = valorTabela[16].Substring(39, 38); break;
                case 4: resultado = valorTabela[17].Substring(39, 38); break;
                case 5: resultado = valorTabela[18].Substring(39, 38); break;
                case 6: resultado = valorTabela[19].Substring(39, 38); break;
                case 7: resultado = valorTabela[20].Substring(39, 38); break;
            }

            return resultado;
        }

        public string valorCancelamentoDeducaoDescricao()
        {
            return valorTabela[27].Substring(39, 38);
        }

        public string valorBxDistribuicaoDeducaoDescricao()
        {
            return valorTabela[23].Substring(39, 38);
        }

        public string valorEditalDeducaoDescricao()
        {
            return valorTabela[21].Substring(39, 38);
        }

        public string valorDistribuidorDeducaoDescricao()
        {
            return valorTabela[22].Substring(39, 38);
        }

        public string valorCustaCertidaoDeducaoDescricao(int opcao, int informacoes)
        {
            string resultado = "";
            if (opcao == 0)
                resultado = valorTabela[26].Substring(39, 38);
            else
            {
                if (informacoes > 1)
                {
                    double valorA = double.Parse(valorTabela[24].Substring(47, 4));
                    double valorB = double.Parse(valorTabela[24].Substring(61, 5));
                    valorA += ((informacoes - 1) * double.Parse(valorTabela[25].Substring(47, 4)));
                    valorB += ((informacoes - 1) * double.Parse(valorTabela[25].Substring(62, 4)));
                    resultado += "FAADEP " + string.Format("{0:0.00}",valorA) + " FERMOJU " + string.Format("{0:0.00}",valorB) +" "+ valorTabela[24].Substring(67, 10);
                }else
                    resultado = valorTabela[26].Substring(39, 38);
            }

            return resultado;
        }

    }
}

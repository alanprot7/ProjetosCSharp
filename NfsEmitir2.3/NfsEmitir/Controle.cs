using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NfsEmitir
{
    class Controle
    {
        Tabela tabela = new Tabela();
        int giroProtocolo = 0;
        int giroCertidao = 0;

        List<Protocolo> protocolos = new List<Protocolo>();
        List<Certidao> certidoes = new List<Certidao>();

        public void geraProtocolo(string numero, double valor)
        {
            Protocolo protocolo = new Protocolo();

            string descricao = "PROTOCOLO Nº: " + numero;
            protocolo.setDescricao(descricao);
            protocolo.setNumero(numero);
            protocolo.setValor(valor);

            protocolos.Add(protocolo);

        }

        public void geraCertidao(string nome, int opcao, int informacao)
        {
            Certidao certidao = new Certidao();

            string descricao = "CERTIDÃO: " + nome;
            certidao.setNome(nome.ToUpper());
            certidao.setCustasTotal(tabela.valorCustaCertidao(opcao, informacao));
            certidao.setCustasDeducao(tabela.valorCustaCertidaoDeducao(opcao, informacao));

            if (opcao == 0)
                descricao += " | " + "EMOLUMENTOS DE CERTIDÃO NEGATIVA R$ " + string.Format("{0:0.00}", certidao.getCustasTotal());
            else
                descricao += " | " + "EMOLUMENTOS DE CERTIDÃO POSITIVA COM " + informacao + " Inf. R$ " + string.Format("{0:0.00}", certidao.getCustasTotal());

            descricao += " | " + "DEDUCAO " + tabela.valorCustaCertidaoDeducaoDescricao(opcao, informacao);

            certidao.setDescricao(descricao.ToUpper());

            certidoes.Add(certidao);
        }

        public void escolheOpcao(bool protesto, bool cancelamento, bool distribuicao, bool bxDist, bool devolucao, bool edital, bool pagamento, bool txEdital, bool menosTx)
        {
            if (protesto)
            {
                string descricao = protocolos[giroProtocolo].getDescricao();
                double somaTotal = soma(protocolos[giroProtocolo].getCustaTotal(), tabela.valorProtesto(protocolos[giroProtocolo].getValor()));
                double somaDeducao = soma(protocolos[giroProtocolo].getCustaDeducao(), tabela.valorProtestoDeducao(protocolos[giroProtocolo].getValor()));
                descricao += " | " + "EMOLUMENTOS DE PROTESTO R$ " + string.Format("{0:0.00}", tabela.valorProtesto(protocolos[giroProtocolo].getValor())) + " | " + "DEDUÇÃO " + tabela.valorProtestoDeducaoDescricao(protocolos[giroProtocolo].getValor());
                protocolos[giroProtocolo].setDescricao(descricao);
                protocolos[giroProtocolo].setCustaTotal(somaTotal);
                protocolos[giroProtocolo].setCustaDeducao(somaDeducao);

            }

            if (cancelamento)
            {
                string descricao = protocolos[giroProtocolo].getDescricao();
                double somaTotal = soma(protocolos[giroProtocolo].getCustaTotal(), tabela.valorCancelamento());
                double somaDeducao = soma(protocolos[giroProtocolo].getCustaDeducao(), tabela.valorCancelamentoDeducao());
                descricao += " | " + "EMOLUMENTOS DE CANCELAMENTO R$ " + string.Format("{0:0.00}", tabela.valorCancelamento()) + " | " + "DEDUÇÃO " + tabela.valorCancelamentoDeducaoDescricao();
                protocolos[giroProtocolo].setDescricao(descricao);
                protocolos[giroProtocolo].setCustaTotal(somaTotal);
                protocolos[giroProtocolo].setCustaDeducao(somaDeducao);
            }

            if (devolucao)
            {
                string descricao = protocolos[giroProtocolo].getDescricao();
                double somaTotal = soma(protocolos[giroProtocolo].getCustaTotal(), tabela.valorDevolucao(protocolos[giroProtocolo].getValor()));
                double somaDeducao = soma(protocolos[giroProtocolo].getCustaDeducao(), tabela.valorDevolucaoDeducao(protocolos[giroProtocolo].getValor()));
                descricao += " | " + "EMOLUMENTOS DE DEVOLUÇÃO R$ " + string.Format("{0:0.00}", tabela.valorDevolucao(protocolos[giroProtocolo].getValor())) + " | " + "DEDUÇÃO " + tabela.valorDevolucaoDeducaoDescricao(protocolos[giroProtocolo].getValor());
                protocolos[giroProtocolo].setDescricao(descricao);
                protocolos[giroProtocolo].setCustaTotal(somaTotal);
                protocolos[giroProtocolo].setCustaDeducao(somaDeducao);
            }

            if (edital)
            {
                string descricao = protocolos[giroProtocolo].getDescricao();
                double somaTotal = soma(protocolos[giroProtocolo].getCustaTotal(), tabela.valorEdital());
                double somaDeducao = soma(protocolos[giroProtocolo].getCustaDeducao(), tabela.valorEditalDeducao());
                descricao += " | " + "EMOLUMENTOS DE EDITAL R$ " + string.Format("{0:0.00}", tabela.valorEdital()) + " | " + "DEDUÇÃO " + tabela.valorEditalDeducaoDescricao();
                protocolos[giroProtocolo].setDescricao(descricao);
                protocolos[giroProtocolo].setCustaTotal(somaTotal);
                protocolos[giroProtocolo].setCustaDeducao(somaDeducao);
            }

            if (pagamento)
            {
                string descricao = protocolos[giroProtocolo].getDescricao();
                double somaTotal = soma(protocolos[giroProtocolo].getCustaTotal(), tabela.valorPagamento(protocolos[giroProtocolo].getValor()));
                double somaDeducao = soma(protocolos[giroProtocolo].getCustaDeducao(), tabela.valorPagamentoDeducao(protocolos[giroProtocolo].getValor()));
                descricao += " | " + "EMOLUMENTOS DE PAGAMENTO R$ " + string.Format("{0:0.00}", tabela.valorPagamento(protocolos[giroProtocolo].getValor())) + " | " + "DEDUÇÃO " + tabela.valorPagamentoDeducaoDescricao(protocolos[giroProtocolo].getValor());
                protocolos[giroProtocolo].setDescricao(descricao);
                protocolos[giroProtocolo].setCustaTotal(somaTotal);
                protocolos[giroProtocolo].setCustaDeducao(somaDeducao);
            }

            if (distribuicao)
            {
                string descricao = protocolos[giroProtocolo].getDescricao();
                double somaTotal = soma(protocolos[giroProtocolo].getCustaTotal(), tabela.valorDistribuidor());
                double somaDeducao = soma(protocolos[giroProtocolo].getCustaDeducao(), tabela.valorDistribuidorDeducao());
                descricao += " | " + "REPASSE DE DISTRIBUIÇÃO R$ " + string.Format("{0:0.00}", tabela.valorDistribuidor().ToString().Trim()) + " | " + "DEDUÇÃO REPASSE " + tabela.valorDistribuidorDeducaoDescricao().ToString().Trim();
                protocolos[giroProtocolo].setDescricao(descricao);
                protocolos[giroProtocolo].setCustaTotal(somaTotal);
                protocolos[giroProtocolo].setCustaDeducao(somaDeducao);

            }

            if (bxDist)
            {
                string descricao = protocolos[giroProtocolo].getDescricao();
                double somaTotal = soma(protocolos[giroProtocolo].getCustaTotal(), tabela.valorBxDistribuicao());
                double somaDeducao = soma(protocolos[giroProtocolo].getCustaDeducao(), tabela.valorBxDistribuicaoDeducao());
                descricao += " | " + "REPASSE DE BAIXA DISTRIBUIÇÃO R$ " + string.Format("{0:0.00}", tabela.valorBxDistribuicao().ToString().Trim()) + " | " + "DEDUÇÃO REPASSE " + tabela.valorBxDistribuicaoDeducaoDescricao().ToString().Trim();
                protocolos[giroProtocolo].setDescricao(descricao);
                protocolos[giroProtocolo].setCustaTotal(somaTotal);
                protocolos[giroProtocolo].setCustaDeducao(somaDeducao);
            }

            if (txEdital && !menosTx)
            {
                string descricao = protocolos[giroProtocolo].getDescricao();
                double somaTotal = soma(protocolos[giroProtocolo].getCustaTotal(), tabela.valorTxEdital());
                double somaDeducao = soma(protocolos[giroProtocolo].getCustaDeducao(), tabela.valorTxEditalDeducao());
                descricao += " | " + "TAXA DE PUBLICAÇÃO DE EDITAL R$ " + string.Format("{0:0.00}", tabela.valorTxEdital().ToString().Trim()) + " | " + "DEDUÇÃO FAADEP " + tabela.valorTxEditalDeducao().ToString().Trim();
                protocolos[giroProtocolo].setDescricao(descricao);
                protocolos[giroProtocolo].setCustaTotal(somaTotal);
                protocolos[giroProtocolo].setCustaDeducao(somaDeducao);
            }
            else            
                if (txEdital && menosTx)
                {
                    string descricao = protocolos[giroProtocolo].getDescricao();
                    double somaTotal = soma(protocolos[giroProtocolo].getCustaTotal(), (tabela.valorTxEdital()*-1));

                    descricao += " | " + "ABATIMENTO DE ADIANTAMENTO DE TAXA DE PUBLICAÇÃO DE EDITAL R$ " + string.Format("-{0:0.00}", tabela.valorTxEdital().ToString().Trim());
                    protocolos[giroProtocolo].setDescricao(descricao);
                    protocolos[giroProtocolo].setCustaTotal(somaTotal);
                }
 
            




        }


        public string montaTela()
        {
            string tela = "";
            foreach (Protocolo prot in protocolos)
            {
                tela += prot.getDescricao() + Environment.NewLine;
            }

            foreach (Certidao cert in certidoes)
            {
                tela += cert.getDescricao() + Environment.NewLine;
            }

            return tela;
        }

        public string calculaValorTotal()
        {
            string resultado = string.Format("{0:0.00}", varreTotal());

            return resultado;
        }

        public string calculaDeducao()
        {
            string resultado = string.Format("{0:0.00}", varreTotalDeducao());
            return resultado;
        }

        public void carregaTabela(int ano)
        {
            string[] opAno = { "tabela.ini", "tabela2017.ini" };
            tabela.inicia(opAno[ano]);
        }

        public string informaProtocolo()
        {
            return protocolos[giroProtocolo].getNumero();
        }

        public string informaCertidaoNome()
        {
            return certidoes[giroCertidao].getNome();
        }

        public double varreTotal()
        {
            double resultado = 0;
            foreach (Protocolo prot in protocolos)
            {
                resultado += prot.getCustaTotal();
            }

            foreach (Certidao cert in certidoes)
            {
                resultado += cert.getCustasTotal();
            }

            return resultado;
        }

        public double varreTotalDeducao()
        {
            double resultado = 0;
            foreach (Protocolo prot in protocolos)
            {
                resultado += prot.getCustaDeducao();
            }

            foreach (Certidao cert in certidoes)
            {
                resultado += cert.getCustasDeducao();
            }

            return resultado;
        }

        public double soma(double valorClasse, double valorSoma)
        {
            return valorClasse += valorSoma;
        }

        public void giraProtocolo()
        {
            giroProtocolo++;
        }

        public void giraCertidao()
        {
            giroCertidao++;
        }

        public void removerProtocolo(int posicao)
        {
            protocolos.Remove(protocolos[posicao]);
            giroProtocolo--;
        }
        public void removerCertidao(int posicao)
        {
            certidoes.Remove(certidoes[posicao]);
            giroCertidao--;
        }
    }
}

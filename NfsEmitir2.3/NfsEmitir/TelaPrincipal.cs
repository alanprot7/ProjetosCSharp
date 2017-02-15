using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NfsEmitir
{
    public partial class TelaPrincipal : Form
    {
        Controle controle = new Controle();

        public TelaPrincipal()
        {
            
            InitializeComponent();
            try
            {
                int anoTabela = int.Parse(InputBox("Escolha a Tabela de Valores:\nTabela (2016) digite 0\nTabela (2017) digite 1", "Tabela de Valores", "1"));
                controle.carregaTabela(anoTabela);
                if (anoTabela == 0)
                    lbTabela.Text = "Tabela 2016";
                else
                    lbTabela.Text = "Tabela 2017";
            }
            catch {
                controle.carregaTabela(1);
                lbTabela.Text = "Tabela 2017";
            }

            radioProtocolo.Checked = true;
            radioNegativa.Checked = true;
            radioProtocolo.Checked = true;
            radioMenosTxEdital.Checked = true;
            radioMenosTxEdital.Enabled = false;
            radioMaisTxEdital.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioProtocolo.Checked)
                acaoProtocolo();
            else
                if (radioCertidao.Checked)
                    acaoCertidao();
                else
                    acaoRemover();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextTela.TextLength > 0)
            {
                Clipboard.SetText(controle.montaTela());
                MessageBox.Show("Copiado para a Memoria!!");
            }
        }

        private void radioProtocolo_CheckedChanged(object sender, EventArgs e)
        {

            enableProtocolo(true);
            enableCertidao(false);
            groupListas.Enabled = false;

        }

        private void radioCertidao_CheckedChanged(object sender, EventArgs e)
        {
            enableProtocolo(false);
            enableCertidao(true);
            groupListas.Enabled = false;

        }

        private void radioRemover_CheckedChanged(object sender, EventArgs e)
        {
            enableCertidao(false);
            enableProtocolo(false);
            groupListas.Enabled = true;
        }


        private void enableCertidao(bool status)
        {
            textBoxCertidaoNome.Enabled = status;
            groupCertidao.Enabled = status;

        }

        private void enableProtocolo(bool status)
        {
            textBoxProtocolo.Enabled = status;
            textBoxValor.Enabled = status;
            checkBaixa.Enabled = status;
            checkCancelamento.Enabled = status;
            checkDevolucao.Enabled = status;
            checkDistribuicao.Enabled = status;
            checkEdital.Enabled = status;
            checkProstesto.Enabled = status;
            checkPagamento.Enabled = status;
            checkTxEdital.Enabled = status;
            
            if (checkTxEdital.Checked)
            {
                radioMaisTxEdital.Enabled = status;
                radioMenosTxEdital.Enabled = status;
            }
        }

        private void radioNegativa_CheckedChanged(object sender, EventArgs e)
        {
            numInformacoes.Enabled = false;
        }

        private void radioPositiva_CheckedChanged(object sender, EventArgs e)
        {
            numInformacoes.Enabled = true;
        }

        private void checkCancelamento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCancelamento.Checked)
            {
                checkBaixa.Checked = true;

            }
        }

        private void acaoProtocolo()
        {
            try
            {
                controle.geraProtocolo(textBoxProtocolo.Text, double.Parse(textBoxValor.Text));
                controle.escolheOpcao(checkProstesto.Checked, checkCancelamento.Checked, checkDistribuicao.Checked, checkBaixa.Checked, checkDevolucao.Checked, checkEdital.Checked, checkPagamento.Checked, checkTxEdital.Checked, radioMenosTxEdital.Checked);
                comboProtocolo.Items.Add(controle.informaProtocolo());
                montaTudo();
                controle.giraProtocolo();
                limpaProtocolo();
            }
            catch
            {
                MessageBox.Show("O Campo Valor do Título deve conter valores numéricos, e não pode ser vazio");
                textBoxValor.Text = "";
            }
        }

        private void acaoCertidao()
        {
            if (textBoxCertidaoNome.Text != "" && textBoxCertidaoNome.Text != " ")
            {
                int negativa = 0;
                int positiva = 1;

                if (radioNegativa.Checked)
                    controle.geraCertidao(textBoxCertidaoNome.Text, negativa, 0);
                else
                    controle.geraCertidao(textBoxCertidaoNome.Text, positiva, int.Parse(numInformacoes.Value.ToString()));
                comboCertidao.Items.Add(controle.informaCertidaoNome());

                textBoxCertidaoNome.Text = "";
                radioNegativa.Checked = true;
                numInformacoes.Value = 1;
                controle.giraCertidao();
                montaTudo();
            }

        }

        private void acaoRemover()
        {
            if (comboProtocolo.SelectedIndex >= 0)
            {
                controle.removerProtocolo(comboProtocolo.SelectedIndex);
                comboProtocolo.Items.RemoveAt(comboProtocolo.SelectedIndex);
                comboProtocolo.Text = "";
                montaTudo();
            }

            if (comboCertidao.SelectedIndex >= 0)
            {
                controle.removerCertidao(comboCertidao.SelectedIndex);
                comboCertidao.Items.RemoveAt(comboCertidao.SelectedIndex);
                comboCertidao.Text = "";
                montaTudo();
            }

        }

        private void limpaProtocolo()
        {
            textBoxProtocolo.Text = "";
            textBoxValor.Text = "";
            checkBaixa.Checked = false;
            checkCancelamento.Checked = false;
            checkDevolucao.Checked = false;
            checkDistribuicao.Checked = false;
            checkEdital.Checked = false;
            checkProstesto.Checked = false;
            checkPagamento.Checked = false;
            checkTxEdital.Checked = false;
            
        }

        public void montaTudo()
        {
            richTextTela.Text = controle.montaTela();
            textBoxValorTotal.Text = controle.calculaValorTotal();
            textBoxDeducao.Text = controle.calculaDeducao();
        }

        private void checkDevolucao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDevolucao.Checked)
            {
                checkBaixa.Checked = true;

            }
        }

        private void checkTxEdital_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTxEdital.Checked)
            {
                radioMenosTxEdital.Enabled = true;
                radioMaisTxEdital.Enabled = true;
                radioMenosTxEdital.Checked = true;
            }

            if (!checkTxEdital.Checked)
            {
                radioMenosTxEdital.Enabled = false;
                radioMaisTxEdital.Enabled = false;
            }
        }


        public string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            if (s == string.Empty)
                return "";
            else
                return s;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Apsoo
{
    public partial class TelaPrincipal : Form
    {
        Thread relogioThread;
        bool execucaoThread = true;
        ControlePonto controle = new ControlePonto();
        bool insertHorario = true;
        bool insertFuncionario = true;

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void relogioMostrador()
        {

            while (execucaoThread)
            {
                SetText(DateTime.Now.ToLongTimeString(), lblHora);
                SetText(DateTime.Now.ToShortDateString(), lblData);
                Thread.Sleep(100);
            }

        }

        delegate void SetTextCallback(string text, Label label);

        private void SetText(string text, Label label)
        {

            if (label.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text, label });
            }
            else
            {
                label.Text = text;
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            relogioThread.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            relogioThread = new Thread(new ThreadStart(relogioMostrador));
            relogioThread.Start();
            txbMatricula.Select();
            permitirAcessoAdmin(false);
            comportamentoIncial();
            picFametro.Image = Apsoo.Properties.Resources.Fametro;
        }

        private void txbMatricula_Leave(object sender, EventArgs e)
        {
            string texto = txbMatricula.Text.Trim();
            if (texto.Length > 0)
            {
                try
                {
                    controle.registro.Matricula = int.Parse(txbMatricula.Text);
                    MessageBox.Show(controle.registraBatida());
                    txbMatricula.Text = "";
                    txbMatricula.Select();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    txbMatricula.Text = "";
                    txbMatricula.Select();
                }
            }
        }

        private void abasGeral_Click(object sender, EventArgs e)
        {
            if (abasGeral.SelectedIndex == 0)
                txbMatricula.Select();
            if (abasGeral.SelectedIndex == 1)
                txbSenhAdmin.Select();
        }

        private void permitirAcessoAdmin(bool opcao)
        {
            if (opcao)
            {
                abasGeral.TabPages.Add(tabPage3);
                abasGeral.TabPages.Add(tabPage4);
            }
            if (!opcao)
            {
                abasGeral.TabPages.Remove(tabPage3);
                abasGeral.TabPages.Remove(tabPage4);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            controle.carregaSenha();

            if (controle.Senha.Length > 0)
            {
                if (!abasGeral.TabPages.Contains(tabPage3))
                    if (controle.Senha.Equals(txbSenhAdmin.Text))
                    {
                        permitirAcessoAdmin(true);
                        btnLogin.Text = "LOGOUT";
                        txbSenhAdmin.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta");
                        txbSenhAdmin.Text = "";
                    }
                else
                {
                    permitirAcessoAdmin(false);
                    btnLogin.Text = "LOGIN";
                }


            }
            else
                cadastrarNovaSenha();

        }

        private void cadastrarNovaSenha()
        {
            pnNovaSenha.Visible = true;
        }

        private void btnCadastraSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text.Equals(txtConfirmaSenha.Text))
            {
                controle.Senha = txtConfirmaSenha.Text;
                controle.cadastraSenha();
                txtNovaSenha.Text = "";
                txtConfirmaSenha.Text = "";
                pnNovaSenha.Visible = false;
            }
            else
            {
                MessageBox.Show("Senhas não Conferem!!");
                txtConfirmaSenha.Text = "";
            }
        }

        private void comportamentoIncial()
        {
            btnSalvarFuncionario.Enabled = false;
            btnExcluirFuncionario.Enabled = false;
            btnExcluirHorario.Enabled = false;
            cbHorario.Enabled = false;
            radioPorDia.Checked = true;
            habilitaCamposHorario(false);
            dataGridHorario.Enabled = false;
            dataGridFuncionario.Enabled = false;
            btnSalvarHorario.Enabled = false;
            txbFuncionarioMatricula.Enabled = false;
        }

        private void radioIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIndividual.Checked == true)
            {
                dtpDataInicial.Enabled = true;
                dtpDataFinal.Enabled = true;
                gbFuncionarioLista.Enabled = true;
            }

        }

        private void radioFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFuncionario.Checked == true)
            {
                dtpDataInicial.Enabled = false;
                dtpDataFinal.Enabled = false;
                gbFuncionarioLista.Enabled = false;
            }
        }

        private void btnNovoHorario_Click(object sender, EventArgs e)
        {

            txbDescricao.Enabled = true;
            txbEntrada.Enabled = true;
            txbSaida.Enabled = true;
            txbTolerancia.Enabled = true;
            dataGridHorario.Enabled = true;
            btnSalvarHorario.Enabled = true;
            btnExcluirHorario.Enabled = false;
            btnPesquisarHorario.Enabled = false;
            btnNovoHorario.Enabled = false;
            insertHorario = true;
            limpaCamposHorario();
        }

        private void btnSalvarHorario_Click(object sender, EventArgs e)
        {
            if (insertHorario)
            {
                controle.horario.Descricao = txbDescricao.Text;
                controle.horario.HoraEntrada = txbEntrada.Text;
                controle.horario.HoraSaida = txbSaida.Text;
                controle.horario.Tolerancia = txbTolerancia.Text;
                controle.cadastrarHorario();
                btnPesquisarHorario.Enabled = true;
                btnPesquisarHorario.PerformClick();
                btnSalvarHorario.Enabled = false;
                habilitaCamposHorario(false);
                btnNovoHorario.Enabled = true;
                limpaCamposHorario();
            }
            else
            {
                controle.horario.Descricao = txbDescricao.Text;
                controle.horario.HoraEntrada = txbEntrada.Text;
                controle.horario.HoraSaida = txbSaida.Text;
                controle.horario.Tolerancia = txbTolerancia.Text;
                controle.atualizarHoraio();
                btnPesquisarHorario.Enabled = true;
                btnPesquisarHorario.PerformClick();
                btnSalvarHorario.Enabled = false;
                insertHorario = true;
                btnExcluirHorario.Enabled = false;
                habilitaCamposHorario(false);
                btnNovoHorario.Enabled = true;
                limpaCamposHorario();

            }

        }

        private void limpaCamposHorario()
        {
            txbDescricao.Text = "";
            txbEntrada.Text = "";
            txbSaida.Text = "";
            txbTolerancia.Text = "";
        }

        private void limpaCamposFuncionario()
        {
            txbFuncionarioMatricula.Text = "";
            txbFuncionarioNome.Text = "";
            cbHorario.SelectedIndex = -1;
            cbHorario.Items.Clear();
            string[] descricao = controle.carregaDropDowDescricaoFuncionario();
            cbHorario.Items.AddRange(descricao);
        }

        private void habilitaCamposHorario(bool opcao)
        {
            txbEntrada.Enabled = opcao;
            txbSaida.Enabled = opcao;
            txbTolerancia.Enabled = opcao;
            txbDescricao.Enabled = !opcao;
        }

        private void habilitaCamposFuncionario(bool opcao)
        {
            txbFuncionarioNome.Enabled = opcao;
            txbFuncionarioMatricula.Enabled = !opcao;
            cbHorario.Enabled = opcao;
        }

        private void btnPesquisarHorario_Click(object sender, EventArgs e)
        {
            controle.horario.Descricao = txbDescricao.Text;
            dataGridHorario.DataSource = controle.consultaHorario();
            dataGridHorario.Enabled = true;

        }

        private void btnExcluirHorario_Click(object sender, EventArgs e)
        {
            controle.horario.Descricao = txbDescricao.Text;
            controle.excluirHorario();
            btnExcluirHorario.Enabled = false;
            insertHorario = true;
            habilitaCamposHorario(false);
            btnSalvarHorario.Enabled = false;
            limpaCamposHorario();
            btnNovoHorario.Enabled = true;
            btnPesquisarHorario.Enabled = true;
            btnPesquisarHorario.PerformClick();
        }

        private void dataGridHorario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selectedCellCount =
        dataGridHorario.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (dataGridHorario.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Todas as Celulas foram Selecionadas!!", "Celulas Selecionadas");
                }
                else
                {
                    string[] dados = new string[4];
                    string[] colunas = new string[4];

                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        colunas[i] = (dataGridHorario.SelectedCells[i].OwningColumn.Name.ToString());
                        dados[i] = (dataGridHorario.SelectedCells[i].Value.ToString());

                    }

                    try
                    {
                        if (colunas[0].Equals("colDescricao") &&
                            colunas[1].Equals("colEntrada") &&
                            colunas[2].Equals("colSaida") &&
                            colunas[3].Equals("colTolerancia"))
                        {
                            txbDescricao.Text = dados[0];
                            txbEntrada.Text = dados[1];
                            txbSaida.Text = dados[2];
                            txbTolerancia.Text = dados[3];
                            btnExcluirHorario.Enabled = true;
                            insertHorario = false;
                            habilitaCamposHorario(true);
                            btnSalvarHorario.Enabled = true;
                            btnPesquisarHorario.Enabled = false;
                            btnNovoHorario.Enabled = false;
                        }
                    }
                    catch
                    { }
                }
            }


        }

        private void btnCancelHorario_Click(object sender, EventArgs e)
        {
            limpaCamposHorario();
            btnExcluirHorario.Enabled = false;
            btnSalvarHorario.Enabled = false;
            btnPesquisarHorario.Enabled = true;
            habilitaCamposHorario(false);
            btnNovoHorario.Enabled = true;
            insertHorario = true;
        }

        private void btnImprimirRelatorio_Click(object sender, EventArgs e)
        {
            if (radioFuncionario.Checked == true)
            {
                controle.emitirRelatorioFuncionario();
            }
            if (radioPorDia.Checked == true)
            {
                string[] datas = {dtpDataInicial.Value.Date.ToString("yyy-MM-dd"),
                dtpDataInicial.Value.Date.ToString("dd/MM/yyyy")};
                controle.emitirRelatorioBatida(datas);
            }
            if (radioIndividual.Checked == true)
            {
                string[] datas = {dtpDataInicial.Value.Date.ToString("yyy-MM-dd"),
                                  dtpDataInicial.Value.Date.ToString("dd/MM/yyyy"),
                                  dtpDataFinal.Value.Date.ToString("yyy-MM-dd"),
                                  dtpDataFinal.Value.Date.ToString("dd/MM/yyyy")};

                try
                {
                    if (dgRelatorioFuncionario.SelectedCells[0].OwningColumn.Name.ToString().Equals("colRelatorioMatricula") &&
                        dgRelatorioFuncionario.SelectedCells[0].Value.ToString().Length > 0)
                    {
                        string matricula = dgRelatorioFuncionario.SelectedCells[0].Value.ToString();
                        controle.emitirRelatorioIndividual(datas, matricula);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            controle.funcionario.Nome = txbFuncionarioNome.Text;
            dataGridFuncionario.DataSource = controle.consultarFuncionario();
            dataGridFuncionario.Enabled = true;
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            txbFuncionarioMatricula.Enabled = true;
            txbFuncionarioNome.Enabled = true;
            dataGridFuncionario.Enabled = true;
            btnSalvarFuncionario.Enabled = true;
            btnExcluirFuncionario.Enabled = false;
            btnPesquisarFuncionario.Enabled = false;
            btnNovoFuncionario.Enabled = false;
            cbHorario.Enabled = true;
            insertFuncionario = true;
            limpaCamposFuncionario();

        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (insertFuncionario)
                {
                    controle.funcionario.Nome = txbFuncionarioNome.Text;
                    controle.funcionario.Matricula = int.Parse(txbFuncionarioMatricula.Text);
                    controle.funcionario.Horario = cbHorario.SelectedItem.ToString();
                    controle.cadastrarFuncionario();
                    btnPesquisarFuncionario.Enabled = true;
                    btnPesquisarFuncionario.PerformClick();
                    btnSalvarFuncionario.Enabled = false;
                    habilitaCamposFuncionario(false);
                    txbFuncionarioNome.Enabled = true;
                    txbFuncionarioMatricula.Enabled = false;
                    btnNovoFuncionario.Enabled = true;
                    limpaCamposFuncionario();
                }
                else
                {

                    controle.funcionario.Nome = txbFuncionarioNome.Text;
                    controle.funcionario.Matricula = int.Parse(txbFuncionarioMatricula.Text);
                    controle.funcionario.Horario = cbHorario.SelectedItem.ToString();
                    controle.atualizarFuncionario();
                    btnPesquisarFuncionario.Enabled = true;
                    btnPesquisarFuncionario.PerformClick();
                    btnSalvarFuncionario.Enabled = false;
                    habilitaCamposFuncionario(false);
                    btnNovoFuncionario.Enabled = true;
                    limpaCamposFuncionario();
                    txbFuncionarioNome.Enabled = true;
                    txbFuncionarioMatricula.Enabled = false;
                    insertFuncionario = true;
                    btnExcluirFuncionario.Enabled = false;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dataGridFuncionario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selectedCellCount =
dataGridFuncionario.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (dataGridFuncionario.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Todas as Celulas foram Selecionadas!!", "Celulas Selecionadas");
                }
                else
                {
                    string[] dados = new string[4];
                    string[] colunas = new string[4];

                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        colunas[i] = (dataGridFuncionario.SelectedCells[i].OwningColumn.Name.ToString());
                        dados[i] = (dataGridFuncionario.SelectedCells[i].Value.ToString());

                    }

                    try
                    {
                        if (colunas[0].Equals("colMatricula") &&
                            colunas[1].Equals("colNome") &&
                            colunas[2].Equals("colHorario"))
                        {
                            limpaCamposFuncionario();
                            txbFuncionarioNome.Text = dados[1];
                            txbFuncionarioMatricula.Text = dados[0];
                            cbHorario.SelectedIndex = cbHorario.Items.IndexOf(dados[2]);
                            btnExcluirFuncionario.Enabled = true;
                            insertFuncionario = false;
                            habilitaCamposFuncionario(true);
                            btnSalvarFuncionario.Enabled = true;
                            btnPesquisarFuncionario.Enabled = false;
                            btnNovoFuncionario.Enabled = false;
                        }
                    }
                    catch
                    { }
                }
            }

        }

        private void btnCancelarFuncionario_Click(object sender, EventArgs e)
        {
            limpaCamposFuncionario();
            btnExcluirFuncionario.Enabled = false;
            btnSalvarFuncionario.Enabled = false;
            btnPesquisarFuncionario.Enabled = true;
            habilitaCamposFuncionario(true);
            cbHorario.Enabled = false;
            btnNovoFuncionario.Enabled = true;
            insertFuncionario = true;

        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            controle.funcionario.Matricula = int.Parse(txbFuncionarioMatricula.Text);
            controle.excluirFuncionario();
            btnExcluirFuncionario.Enabled = false;
            insertFuncionario = true;
            habilitaCamposHorario(true);
            cbHorario.Enabled = false;
            btnSalvarFuncionario.Enabled = false;
            limpaCamposFuncionario();
            btnNovoFuncionario.Enabled = true;
            btnPesquisarFuncionario.Enabled = true;
            btnPesquisarFuncionario.PerformClick();
        }

        private void radioPorDia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPorDia.Checked == true)
            {
                dtpDataInicial.Enabled = true;
                dtpDataFinal.Enabled = false;
                gbFuncionarioLista.Enabled = false;
            }
        }

        private void btnConsultaFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                controle.funcionario.Nome = txbRelatorioFuncionario.Text;
                dgRelatorioFuncionario.DataSource = controle.consultaFuncionarioIndividual();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}

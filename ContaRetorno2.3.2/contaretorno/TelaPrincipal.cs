using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace ContaRetorno
{
    public partial class TelaPrincipal : Form
    {
        private bool isBrasil = false;
        private bool isBradesco = false;
        private bool isCef = false;
        private bool isItau = false;
        private bool isHsbc = false;
        private bool isSantander = false;
        private bool isSafra = false;
        private bool isDaycoval = false;
        private bool isBanrisul = false;
        private bool isBic = false;
        private bool isBmb = false;
        private bool isMerril = false;
        private bool isAbc = false;
        private bool isEcocredi = false;
        private bool isXimenes = false;
        private bool isCls = false;
        private bool inconsist = false;
        private bool isArruma = false;

        private string brasil = "";
        private string bradesco = "";
        private string cef = "";
        private string itau = "";
        private string hsbc = "";
        private string santander = "";
        private string safra = "";
        private string daycoval = "";
        private string banrisul = "";
        private string bic = "";
        private string bmb = "";
        private string merril = "";
        private string abc = "";
        private string ecocredi = "";
        private string ximenes = "";
        private string cls = "";
        private string movimento = "";
        private string filtro = "All files (*.161;*.167;*.171;*.177)|*.161;*.167;*.171;*.177";
        private List<string> inconsistencias = new List<string>();
        private List<string> registroConserto = new List<string>();
        ControleProtocolos controle = new ControleProtocolos();
        Conexao conexao = new Conexao();

        public TelaPrincipal()
        {
            InitializeComponent();

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            StreamWriter protocolo = new StreamWriter(@"PROTOCOLO.TXT");
            protocolo.WriteLine("\tCartório João Machado 7º - Protocolo  FEBRABAN (CRA) - DATA " + DateTime.Now.ToShortDateString());
            protocolo.WriteLine();
            protocolo.Write(movimento);


            if (isBrasil == true)
                protocoloPag(protocolo, brasil, "TED");

            if (isBradesco == true)
                protocoloPag(protocolo, bradesco, "TED");

            if (isSantander == true)
                protocoloPag(protocolo, santander, "TED");

            if (isBic == true)
                protocoloPag(protocolo, bic, "TED");

            if (isBmb == true)
                protocoloPag(protocolo, bmb, "TED");

            if (isItau == true)
                protocoloPag(protocolo, itau, "TED");

            if (isCef == true)
                protocoloPag(protocolo, cef, "CHQ");

            if (isHsbc == true)
                protocoloPag(protocolo, hsbc, "TED");

            if (isSafra == true)
                protocoloPag(protocolo, safra, "TED");

            if (isBanrisul == true)
                protocoloPag(protocolo, banrisul, "CHQ");

            if (isDaycoval == true)
                protocoloPag(protocolo, daycoval, "TED");

            if (isMerril == true)
                protocoloPag(protocolo, merril, "TED");

            if (isAbc == true)
                protocoloPag(protocolo, abc, "TED");

            if (isEcocredi == true)
                protocoloPag(protocolo, ecocredi, "TED");

            if (isXimenes == true)
                protocoloPag(protocolo, ximenes, "TED");

            if (isCls == true)
                protocoloPag(protocolo, cls, "TED");

            protocolo.Close();
            Process.Start(@"PROTOCOLO.TXT");
        }

        private string geraString(string[] retorno, string banco, int ctpago, int ctprotestado, int ctdevolvido, int ctsustado,
int pago, int protestado, int devolvido, int sustado)
        {

            string pag = trataValor(pago);
            string prot = trataValor(protestado);
            string dev = trataValor(devolvido);
            string sus = trataValor(sustado);


            banco += "                                DATA MOVIMENTO: " + retorno[1].Substring(477, 2) + "/" + retorno[1].Substring(479, 2) + "/" + retorno[1].Substring(481, 4) + "                ";
            banco += "         +------------------+  ------------------------------------------";
            banco += "         |                  |   Banco: " + retorno[0].Substring(4, 34) + "";
            banco += "         |                  |   Qtd Pagos:" + ("  " + ctpago).Substring(("  " + ctpago).Length - 3, 3) + "   R$ " + ("          " + pag).Substring(("          " + pag).Length - 10, 10) + "            ";
            banco += "         |                  |   Qtd Devol:" + ("  " + ctdevolvido).Substring(("  " + ctdevolvido).Length - 3, 3) + "   R$ " + ("          " + dev).Substring(("          " + dev).Length - 10, 10) + "            ";
            banco += "         |                  |   Qtd Prote:" + ("  " + ctprotestado).Substring(("  " + ctprotestado).Length - 3, 3) + "   R$ " + ("          " + prot).Substring(("          " + prot).Length - 10, 10) + "            ";
            banco += "         |x-----------------|   Qtd Susta:" + ("  " + ctsustado).Substring(("  " + ctsustado).Length - 3, 3) + "   R$ " + ("          " + sus).Substring(("          " + sus).Length - 10, 10) + "            ";
            banco += "         +------------------+  ==========================================";
            return banco;

        }

        private string trataValor(int valor)
        {

            string valorTratado = "" + valor;

            if (valorTratado.Equals("0"))
                valorTratado = "0,00";
            else
                if (valorTratado.Length > 5)
                    valorTratado = valorTratado.Substring(0, valorTratado.Length - 5) + "." + valorTratado.Substring(valorTratado.Length - 5, 3) + "," + valorTratado.Substring(valorTratado.Length - 2, 2);
                else
                    if (valorTratado.Length > 2)
                        valorTratado = valorTratado.Substring(0, valorTratado.Length - 2) + "," + valorTratado.Substring(valorTratado.Length - 2, 2);

            return valorTratado;

        }

        private void btnCargaGeral_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "Selecionar Arquivo";
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = filtro;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.Multiselect = true;
            openFileDialog1.FileName = "";


            //=========================================================

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string local = openFileDialog1.FileName;

                desistBar.Maximum = openFileDialog1.FileNames.Length;

                foreach (String arquivo in openFileDialog1.FileNames)
                {
                    desistBar.PerformStep();
                    string[] retorno = File.ReadAllLines(@arquivo);
                    int ctpago = 0, ctprotestado = 0, ctdevolvido = 0, ctsustado = 0;
                    int pago = 0, protestado = 0, devolvido = 0, sustado = 0;
                    string nome = retorno[0].Substring(4, 40);
                    bool avisoCanc = false;

                    for (int i = 0; i < retorno.Length - 1; i++)
                    {
                        if (retorno[i].Length > 590)
                        {
                            string teste = retorno[i].Substring(0, 590);
                            for (int j = i + 1; j < retorno.Length; j++)
                                if (retorno[j].Length > 590)
                                    if (teste == retorno[j].Substring(0, 590))
                                        MessageBox.Show("EXISTE TITULO DUPLICADO NO " + nome + "\nLINHA (" + (j + 1) +
                                            ")\tMOVIMENTO: " + retorno[1].Substring(477, 2) + "/" + retorno[1].Substring(479, 2) + "/"
                                            + retorno[1].Substring(481, 4), "ATENÇÃO!");
                        }
                    }


                    //  ++++++++++++++++Verifica Inconsistencias+++++++++++++++++++++++++++++

                    for (int i = 0; i < retorno.Length; i++)
                    {


                        if (!retorno[0].Substring(1, 3).Equals("104"))
                        {
                            if (retorno[i].Substring(457, 1).Equals("3"))
                            {
                                string[] desist = controle.consulta(conexao, retorno[i].Substring(447, 10));

                                if (desist[0].Length == 0)
                                {
                                    inconsistencias.Add("Banco " + retorno[0].Substring(1, 3) + " " + retorno[i].Substring(447, 10) + " Sem Pedido");
                                    inconsist = true;
                                    isArruma = true;
                                    consertaArqButton.Enabled = true;
                                }
                            }

                            if (retorno[i].Substring(457, 1).Equals("2"))
                            {
                                string[] desist = controle.consulta(conexao, retorno[i].Substring(447, 10));


                                if (desist[0].Length > 0)
                                {
                                    foreach (string dataP in desist)
                                    {

                                        if (dataP.Length > 0 && dataP.Substring(0, 10).Equals(retorno[i].Substring(447, 10)))
                                        {
                                            int iniAno = 4;
                                            int iniMes = 2;
                                            int iniDia = 0;

                                            for (int vez = 0; vez < 2; vez++)
                                            {
                                                try
                                                {
                                                    int result = int.Parse(dataP.Substring(11, 10).Substring(iniDia, 1));
                                                }
                                                catch
                                                {
                                                    iniDia++; iniMes++; iniAno++;
                                                }
                                            }


                                            int ano1 = int.Parse(dataP.Substring(11, 10).Substring(iniAno, 4));
                                            int ano2 = int.Parse(retorno[i].Substring(481, 4));
                                            int mes1 = int.Parse(dataP.Substring(11, 10).Substring(iniMes, 2));
                                            int mes2 = int.Parse(retorno[i].Substring(479, 2));
                                            int dia1 = int.Parse(dataP.Substring(11, 10).Substring(iniDia, 2));
                                            int dia2 = int.Parse(retorno[i].Substring(477, 2));

                                            if (ano1 > ano2)
                                            {
                                                break;
                                            }
                                            else
                                                if (mes1 > mes2)
                                                {
                                                    break;
                                                }
                                                else
                                                    if (dia1 > dia2)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        inconsistencias.Add("Banco " + retorno[0].Substring(1, 3) + " " + retorno[i].Substring(447, 10) + " Protesto Indevido");
                                                        inconsist = true;
                                                    }
                                        }
                                    }

                                }
                            }
                        }

                    }

                    if (isArruma == true)
                    {
                        if (!registroConserto.Contains(arquivo))
                        {
                            registroConserto.Add(arquivo);
                        }
                        isArruma = false;
                    }

                    //  ++++++++++++++++Verifica Inconsistencias+++++++++++++++++++++++++++++

                    for (int i = 0; i < retorno.Length; i++)
                        if (retorno[i].Substring(457, 1) == "1")
                        {
                            ctpago++;
                            pago += int.Parse(retorno[i].Substring(260, 14));
                        }
                        else
                            if (retorno[i].Substring(457, 1) == "2" || retorno[i].Substring(457, 1) == "C")
                            {
                                ctprotestado++;
                                protestado += int.Parse(retorno[i].Substring(471, 5));
                            }
                            else
                                if (retorno[i].Substring(457, 1) == "3" || retorno[i].Substring(457, 1) == "6")
                                {
                                    ctdevolvido++;
                                    devolvido += int.Parse(retorno[i].Substring(471, 5));
                                }
                                else
                                    if (retorno[i].Substring(457, 1) == "4")
                                    {
                                        ctsustado++;
                                        sustado += int.Parse(retorno[i].Substring(471, 5));
                                    }
                                    else
                                        if (retorno[i].Substring(457, 1) == "0")
                                            avisoCanc = true;


                    if (ctsustado > 0)
                        MessageBox.Show("Exite Titulo SUSTADO no " + nome, "ATENÇÃO!");

                    if (avisoCanc)
                        MessageBox.Show("<<<<TITULO CANCELADO!!!>>>> no " + nome, "ATENÇÃO!");


                    if (retorno[0].Substring(1, 3).Equals("001"))
                    {
                        isBrasil = true;
                        chk001.Checked = true;
                        movimento = "                                DATA MOVIMENTO: " + retorno[1].Substring(477, 2) + "/" + retorno[1].Substring(479, 2) + "/" + retorno[1].Substring(481, 4) + "                ";
                    }
                    else
                        if (retorno[0].Substring(1, 3).Equals("237"))
                        {
                            isBradesco = true;
                            chk237.Checked = true;
                            movimento = "                                DATA MOVIMENTO: " + retorno[1].Substring(477, 2) + "/" + retorno[1].Substring(479, 2) + "/" + retorno[1].Substring(481, 4) + "                ";
                        }
                        else
                            if (retorno[0].Substring(1, 3).Equals("341"))
                            {
                                isItau = true;
                                chk341.Checked = true;
                            }
                            else
                                if (retorno[0].Substring(1, 3).Equals("104"))
                                {
                                    isCef = true;
                                    chk104.Checked = true;
                                }
                                else
                                    if (retorno[0].Substring(1, 3).Equals("399"))
                                    {
                                        isHsbc = true;
                                        chk399.Checked = true;
                                    }
                                    else
                                        if (retorno[0].Substring(1, 3).Equals("033"))
                                        {
                                            isSantander = true;
                                            chk033.Checked = true;
                                        }
                                        else
                                            if (retorno[0].Substring(1, 3).Equals("422"))
                                            {
                                                isSafra = true;
                                                chk422.Checked = true;
                                            }
                                            else
                                                if (retorno[0].Substring(1, 3).Equals("707"))
                                                {
                                                    isDaycoval = true;
                                                    chk707.Checked = true;
                                                }
                                                else
                                                    if (retorno[0].Substring(1, 3).Equals("041"))
                                                    {
                                                        isBanrisul = true;
                                                        chk041.Checked = true;
                                                    }
                                                    else
                                                        if (retorno[0].Substring(1, 3).Equals("320"))
                                                        {
                                                            isBic = true;
                                                            chk320.Checked = true;
                                                        }
                                                        else
                                                            if (retorno[0].Substring(1, 3).Equals("389"))
                                                            {
                                                                isBmb = true;
                                                                chk389.Checked = true;
                                                            }
                                                            else
                                                                if (retorno[0].Substring(1, 3).Equals("755"))
                                                                {
                                                                    isMerril = true;
                                                                    chk755.Checked = true;
                                                                }
                                                                else
                                                                    if (retorno[0].Substring(1, 3).Equals("246"))
                                                                    {
                                                                        isAbc = true;
                                                                        chk246.Checked = true;
                                                                    }
                                                                    else
                                                                        if (retorno[0].Substring(1, 3).Equals("962"))
                                                                        {
                                                                            isEcocredi = true;
                                                                            chk962.Checked = true;
                                                                        }
                                                                        else
                                                                            if (retorno[0].Substring(1, 3).Equals("117"))
                                                                            {
                                                                                isXimenes = true;
                                                                                chk117.Checked = true;
                                                                            }
                                                                            else
                                                                                if (retorno[0].Substring(1, 3).Equals("121"))
                                                                                {
                                                                                    isCls = true;
                                                                                    chk121.Checked = true;
                                                                                }


                    int qtdLb = 0;

                    if (isBrasil == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("001"))
                            brasil = geraString(retorno, brasil, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isBradesco == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("237"))
                            bradesco = geraString(retorno, bradesco, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isItau == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("341"))
                            itau = geraString(retorno, itau, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isCef == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("104"))
                            cef = geraString(retorno, cef, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isSafra == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("422"))
                            safra = geraString(retorno, safra, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isSantander == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("033"))
                            santander = geraString(retorno, santander, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isBanrisul == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("041"))
                            banrisul = geraString(retorno, banrisul, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isDaycoval == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("707"))
                            daycoval = geraString(retorno, daycoval, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isBic == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("320"))
                            bic = geraString(retorno, bic, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isHsbc == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("399"))
                            hsbc = geraString(retorno, hsbc, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    if (isBmb == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("389"))
                            bmb = geraString(retorno, bmb, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }
                    if (isMerril == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("755"))
                            merril = geraString(retorno, merril, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }
                    if (isAbc == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("246"))
                            abc = geraString(retorno, abc, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }
                    if (isEcocredi == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("962"))
                            ecocredi = geraString(retorno, ecocredi, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }
                    if (isXimenes == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("117"))
                            ximenes = geraString(retorno, ximenes, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }
                    if (isCls == true)
                    {
                        qtdLb++;
                        if (retorno[0].Substring(1, 3).Equals("121"))
                            cls = geraString(retorno, cls, ctpago, ctprotestado, ctdevolvido, ctsustado, pago, protestado, devolvido, sustado);
                    }

                    lblQtd.Text = "" + qtdLb;


                }

                geraPlanilha(local, brasil, bradesco, santander, itau, hsbc, daycoval, bmb, bic, safra, merril, abc, ecocredi, ximenes, cls);


                if (inconsist)
                {

                    StreamWriter incons = new StreamWriter(@"Inconsistencias.TXT");

                    incons.WriteLine("\t\tVerificar as Seguintes inconsistencias abaixo");
                    incons.WriteLine();

                    foreach (string verificar in inconsistencias)
                    {
                        incons.WriteLine(verificar);
                    }

                    incons.WriteLine();
                    incons.WriteLine("<<<ATENÇÃO NO ARQUIVO TROCAR O CODIGO DE DEVOLUÇÃO \"3\" POR \"6\"!>>>");
                    incons.WriteLine();
                    incons.WriteLine("\t\tCODIGOS DE IRREGULARIDADES MAIS USADOS:");
                    incons.WriteLine();
                    incons.WriteLine("COD 22 - CEP DO SACADO INCOMPATIVEL COM A PRACA DO PROTESTO");
                    incons.WriteLine("COD 06 - ENDEREÇO DO SACADO INSUFICIENTE");
                    incons.Close();
                    MessageBox.Show("Existem Inconsistencias!!");
                }

                btnGerar.PerformClick();

                if (inconsist)
                {
                    Process.Start(@"Inconsistencias.txt");
                }
            }
        }

        private void btnZera_Click(object sender, EventArgs e)
        {
            isBrasil = false;
            isBradesco = false;
            isCef = false;
            isItau = false;
            isHsbc = false;
            isSantander = false;
            isSafra = false;
            isDaycoval = false;
            isBanrisul = false;
            isBic = false;
            isBmb = false;
            isMerril = false;
            isAbc = false;
            isEcocredi = false;
            isXimenes = false;
            isCls = false;
            inconsist = false;

            brasil = "";
            bradesco = "";
            cef = "";
            itau = "";
            hsbc = "";
            santander = "";
            safra = "";
            daycoval = "";
            banrisul = "";
            bic = "";
            bmb = "";
            merril = "";
            abc = "";
            ecocredi = "";
            ximenes = "";
            cls = "";
            movimento = "";

            chk001.Checked = false;
            chk237.Checked = false;
            chk104.Checked = false;
            chk399.Checked = false;
            chk041.Checked = false;
            chk707.Checked = false;
            chk033.Checked = false;
            chk320.Checked = false;
            chk389.Checked = false;
            chk422.Checked = false;
            chk341.Checked = false;
            chk755.Checked = false;
            chk246.Checked = false;
            chk962.Checked = false;
            chk117.Checked = false;
            chk121.Checked = false;

            lblQtd.Text = "0";

            desistBar.Value = 0;
            inconsistencias.Clear();
            registroConserto.Clear();
            consertaArqButton.Enabled = false;

        }

        private void geraPlanilha(string local, string bc1, string bc2, string bc3, string bc4,
            string bc5, string bc6, string bc7, string bc8, string bc9, string bc10, string bc11, string bc12, string bc13, string bc14)
        {
            string localFinal = local.Substring(0, local.Length - 12);
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            if (isBrasil)
                xlWorkSheet.Cells[1, 1] = bc1.Substring(271, 10); xlWorkSheet.Cells[1, 2] = "Brasil";
            if (isBradesco)
                xlWorkSheet.Cells[2, 1] = bc2.Substring(271, 10); xlWorkSheet.Cells[2, 2] = "Bradesco";
            if (isSantander)
                xlWorkSheet.Cells[3, 1] = bc3.Substring(271, 10); xlWorkSheet.Cells[3, 2] = "Santander";
            if (isItau)
                xlWorkSheet.Cells[4, 1] = bc4.Substring(271, 10); xlWorkSheet.Cells[4, 2] = "Itau";
            if (isHsbc)
                xlWorkSheet.Cells[5, 1] = bc5.Substring(271, 10); xlWorkSheet.Cells[5, 2] = "Hsbc";
            if (isDaycoval)
                xlWorkSheet.Cells[6, 1] = bc6.Substring(271, 10); xlWorkSheet.Cells[6, 2] = "Daycoval";
            if (isBmb)
                xlWorkSheet.Cells[7, 1] = bc7.Substring(271, 10); xlWorkSheet.Cells[7, 2] = "BMB";
            if (isBic)
                xlWorkSheet.Cells[8, 1] = bc8.Substring(271, 10); xlWorkSheet.Cells[8, 2] = "BIC";
            if (isSafra)
                xlWorkSheet.Cells[9, 1] = bc9.Substring(271, 10); xlWorkSheet.Cells[9, 2] = "Safra";
            if (isMerril)
                xlWorkSheet.Cells[10, 1] = bc10.Substring(271, 10); xlWorkSheet.Cells[10, 2] = "Merril";
            if (isAbc)
                xlWorkSheet.Cells[11, 1] = bc11.Substring(271, 10); xlWorkSheet.Cells[11, 2] = "Abc";
            if (isEcocredi)
                xlWorkSheet.Cells[12, 1] = bc12.Substring(271, 10); xlWorkSheet.Cells[12, 2] = "Ecocredi";
            if (isXimenes)
                xlWorkSheet.Cells[13, 1] = bc13.Substring(271, 10); xlWorkSheet.Cells[13, 2] = "Ximenes";
            if (isCls)
                xlWorkSheet.Cells[14, 1] = bc14.Substring(271, 10); xlWorkSheet.Cells[14, 2] = "Cls";


            xlWorkBook.SaveAs(localFinal + "valores.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            xlWorkSheet = null;
            xlWorkBook = null;
            xlApp = null;


        }

        private void consertaArq_Click(object sender, EventArgs e)
        {
            String[] carregaIncons = File.ReadAllLines(@"Inconsistencias.txt");

            foreach (String reg in registroConserto)
            {
                string[] novoArquivoRetorno = File.ReadAllLines(@reg);
                StreamWriter gravando = new StreamWriter(@reg);


                foreach (String nvA in novoArquivoRetorno)
                {
                    if (nvA.Substring(457, 1) == "3")
                    {
                        bool naoTem = true;

                        foreach (String listInco in carregaIncons)
                        {
                            if (listInco.IndexOf("Banco") != -1)
                                if (nvA.IndexOf(listInco.Substring(10, 10)) != -1)
                                {
                                    gravando.WriteLine(nvA.Substring(0, 457) + "6" + nvA.Substring(458, 27) + "22" + nvA.Substring(487, 113));
                                    naoTem = false;
                                    break;
                                }
                        }
                        if (naoTem)
                            gravando.WriteLine(nvA);
                    }
                    else
                        gravando.WriteLine(nvA);
                }



                gravando.Close();
            }


            MessageBox.Show("Arquivos Gerados!");

            btnZera.PerformClick();
            btnCargaGeral.PerformClick();
        }

        private void protocoloPag(StreamWriter protocolo, String bancoOrigem, String meioPagamento)
        {
            string banco = bancoOrigem;

            protocolo.WriteLine();
            protocolo.WriteLine(banco.Substring(74, 73));
            protocolo.WriteLine(banco.Substring(147, 73));
            protocolo.WriteLine(banco.Substring(220, 70) + (banco.Substring(271, 10).Equals("      0,00") ? "   " : meioPagamento));
            protocolo.WriteLine(banco.Substring(293, 73));
            protocolo.WriteLine(banco.Substring(366, 73));
            protocolo.WriteLine(banco.Substring(439, 73));
            protocolo.WriteLine(banco.Substring(512, 73));

        }

    }


}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace severino
{

    public partial class Form1 : Form
    {
        string[] caminho;
        List<Entidades> listaRegistros = new List<Entidades>();

        public Form1()
        {
            caminho = new string[2];
            InitializeComponent();
            if (!File.Exists("severino.ini"))
            {
                File.Create("severino.ini");
                MessageBox.Show("Insira os caminhos em severino.ini\nExemplo:\nC:\\Credenciamento Geral.xls\nC:\\Fotos");
                System.Environment.Exit(0);
            }

            caminho = File.ReadAllLines("severino.ini");

            if (caminho.Length < 2)
            {
                MessageBox.Show("Insira os caminhos em severino.ini\nExemplo:\nC:\\Credenciamento Geral.xls\nC:\\Fotos");
                System.Environment.Exit(0);
            }

            obterPlanilha();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool achou = true;

                string pesq = textBox1.Text.Replace(" ", "");
                                
                if (pesq.Length > 12)
                    pesq = pesq.Substring(pesq.Length-12, 12);

                if (!pesq.Equals(""))
                    for (int i = 0; i < listaRegistros.Count(); i++)
                    {
                        pesq = textBox1.Text.Replace(" ", "");

                        if (pesq.Length > 12)
                            pesq = pesq.Substring(pesq.Length - 12, 12);

                        if (pesq.Equals(listaRegistros[i].reg))
                        {
                            achou = false;
                            nome.Text = "" + listaRegistros[i].nom;
                            empresa.Text = "" + listaRegistros[i].emp;
                            funcao.Text = "" + listaRegistros[i].func;
                            regLido.Text = "" + listaRegistros[i].reg;

                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;

                            if (File.Exists(@caminho[1] + "\\" + listaRegistros[i].reg + ".jpg"))
                            {
                                Image foto = Image.FromFile(@caminho[1] + "\\" + listaRegistros[i].reg + ".jpg");
                                pictureBox1.Image = foto;
                            }
                            else
                                pictureBox1.Image = null;


                            pictureBox2.Image = pic("" + listaRegistros[i].P);
                            pictureBox3.Image = pic("" + listaRegistros[i].F);
                            pictureBox4.Image = pic("" + listaRegistros[i].C);
                            pictureBox5.Image = pic("" + listaRegistros[i].B);
                            pictureBox6.Image = pic("" + listaRegistros[i].H);
                            pictureBox7.Image = pic("" + listaRegistros[i].L);
                            pictureBox8.Image = pic("" + listaRegistros[i].um);
                            pictureBox9.Image = pic("" + listaRegistros[i].dois);
                            pictureBox10.Image = pic("" + listaRegistros[i].tres);
                            pictureBox11.Image = pic("" + listaRegistros[i].quatro);
                            pictureBox12.Image = pic("" + listaRegistros[i].cinco);
                            pictureBox13.Image = pic("" + listaRegistros[i].seis);
                            pictureBox14.Image = pic("" + listaRegistros[i].sete);



                        }

                    }

                if (achou)
                {
                    nome.Text = ".";
                    empresa.Text = ".";
                    funcao.Text = ".";
                    regLido.Text = "...";
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    pictureBox5.Image = null;
                    pictureBox6.Image = null;
                    pictureBox7.Image = null;
                    pictureBox8.Image = null;
                    pictureBox9.Image = null;
                    pictureBox10.Image = null;
                    pictureBox11.Image = null;
                    pictureBox12.Image = null;
                    pictureBox13.Image = null;
                    pictureBox14.Image = null;
                    MessageBox.Show("Registro não encontrado");

                }

                textBox1.Text = "";
                textBox1.Focus();

            }

        }

        public Image pic(string letra)
        {
            Image foto = null;
            letra = letra.ToUpper();
            letra = letra.Replace(" ", "");
            if (letra.Equals(""))
                letra = "X";

            switch (letra)
            {

                case "A": foto = severino.Properties.Resources.A; break;
                case "P": foto = severino.Properties.Resources.P; break;
                case "F": foto = severino.Properties.Resources.F; break;
                case "C": foto = severino.Properties.Resources.C; break;
                case "B": foto = severino.Properties.Resources.B; break;
                case "H": foto = severino.Properties.Resources.H; break;
                case "X": foto = severino.Properties.Resources.X; break;
                case "L": foto = severino.Properties.Resources.L; break;
                case "1": foto = severino.Properties.Resources.um; break;
                case "2": foto = severino.Properties.Resources.dois; break;
                case "3": foto = severino.Properties.Resources.tres; break;
                case "4": foto = severino.Properties.Resources.quatro; break;
                case "5": foto = severino.Properties.Resources.cinco; break;
                case "6": foto = severino.Properties.Resources.seis; break;
                case "7": foto = severino.Properties.Resources.sete; break;
                case "S": foto = severino.Properties.Resources.S; break;
                case "M": foto = severino.Properties.Resources.M; break;
                case "U": foto = severino.Properties.Resources.U; break;
                case "R": foto = severino.Properties.Resources.R; break;
                case "V": foto = severino.Properties.Resources.V; break;
                case "E": foto = severino.Properties.Resources.E; break;
                case "O": foto = severino.Properties.Resources.O; break;
                case "T": foto = severino.Properties.Resources.T; break;



            }
            return foto;
        }

        public void obterPlanilha()
        {
            OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + caminho[0] + ";Extended Properties=Excel 12.0 Xml;");
            string comandoSql = "SELECT * FROM [Plan1$]";
            OleDbDataAdapter comando = new OleDbDataAdapter(comandoSql, conexao);
            DataSet ds = new DataSet();
            try
            {
                conexao.Open();
                comando.Fill(ds);
                foreach (DataRow leu in ds.Tables[0].Rows)
                {

                    listaRegistros.Add(new Entidades()
                    {
                        emp = leu["EMPRESA"].ToString(),
                        nom = leu["NOME"].ToString(),
                        func = leu["FUNÇÃO"].ToString(),
                        reg = leu["REGISTRO"].ToString(),
                        P = leu["P"].ToString(),
                        F = leu["F"].ToString(),
                        C = leu["C"].ToString(),
                        B = leu["B"].ToString(),
                        H = leu["H"].ToString(),
                        L = leu["L"].ToString(),
                        um = leu["1"].ToString(),
                        dois = leu["2"].ToString(),
                        tres = leu["3"].ToString(),
                        quatro = leu["4"].ToString(),
                        cinco = leu["5"].ToString(),
                        seis = leu["6"].ToString(),
                        sete = leu["7"].ToString(),


                    });
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível ler a Planilha");
            }
            finally
            {
                conexao.Close();
            }
        }

    }

}

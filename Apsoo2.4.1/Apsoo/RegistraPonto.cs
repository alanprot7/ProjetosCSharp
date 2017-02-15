using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Apsoo
{
    class RegistraPonto
    {
        private string ticket = "";

        public string registraPonto(Conexao conexao, Registro registro)
        {
            DateTime dataHora = System.DateTime.Now;
            string dataRegistro = dataHora.ToString("yyyy-MM-dd");
            string dataTicket = dataHora.ToString("dd/MM/yyyy");
            string horaEntrada = dataHora.ToString("HH:mm");
            string horaSaida = dataHora.ToString("HH:mm");
            string registroSaida = "";
            string nomeFuncionario = "";
            string registoEntrada = "";

            try
            {
                string sqlGetNome = string.Format("SELECT nome FROM funcionario WHERE matricula = {0};", registro.Matricula);
                string sqlGet = string.Format("SELECT * FROM registro WHERE data = '{0}' and matricula = {1};", dataRegistro, registro.Matricula);
                string sqlSetEntrada = string.Format("INSERT INTO registro(matricula,data,entrada) VALUES({0},'{1}','{2}');", registro.Matricula, dataRegistro, horaEntrada);
                string sqlSetSaida = string.Format("UPDATE registro SET saida = '{0}' WHERE data = '{1}' and matricula = {2};", horaSaida, dataRegistro, registro.Matricula);

                DataTable datanome = conexao.getDados(sqlGetNome);


                foreach (DataRow row in datanome.Rows)
                {
                    nomeFuncionario = row["nome"].ToString();
                }

                DataTable data = conexao.getDados(sqlGet);

                foreach (DataRow row in data.Rows)
                {
                    registroSaida = row["saida"].ToString();
                    registoEntrada = row["entrada"].ToString();
                }


                if (registroSaida.ToString().Length > 0)
                {
                    return "Horário Completo";
                }
                else
                {
                    if (registoEntrada.ToString().Length > 0)
                    {

                        conexao.setDados(sqlSetSaida);
                        return montaTicket(string.Format("{0}", registro.Matricula),
                             dataTicket,
                             horaSaida,
                             nomeFuncionario);
                    }
                    else
                    {

                        conexao.setDados(sqlSetEntrada);
                        return montaTicket(string.Format("{0}", registro.Matricula),
                              dataTicket,
                              horaEntrada,
                              nomeFuncionario);

                    }
                }

            }
            catch (Exception)
            {
                throw new Exception("Funcionario nâo Cadastrado");
            }
            finally
            {
                ticket = "";
            }

        }


        private string montaTicket(string matricula, string data, string horario, string nome)
        {

            ticket += "+++++++++++++Emitindo Ticket+++++++++++++" + Environment.NewLine;
            ticket += "====================================" + Environment.NewLine;
            ticket += "Matricula:\t " + matricula + Environment.NewLine;
            ticket += "Nome:\t " + nome + Environment.NewLine;
            ticket += "Hora:\t " + horario + Environment.NewLine;
            ticket += "Data:\t " + data + Environment.NewLine;
            ticket += "====================================";

            return ticket;
        }
    }
}

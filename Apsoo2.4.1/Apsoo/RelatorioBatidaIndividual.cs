using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Apsoo
{
    class RelatorioBatidaIndividual
    {
        public void batidas(Conexao conexao, string[] datas, string matricula)
        {
            string sqlpart = "SELECT r.data, r.entrada, r.saida, f.matricula , f.nome, SEC_TO_TIME(IF( (TIME_TO_SEC(h.entrada) - TIME_TO_SEC(r.entrada)) > '-60' && (TIME_TO_SEC(h.entrada) - TIME_TO_SEC(r.entrada)) <= TIME_TO_SEC(h.tolerancia), '0' , IF( (TIME_TO_SEC(h.entrada) - TIME_TO_SEC(r.entrada)) < '-60' && (TIME_TO_SEC(h.entrada) - TIME_TO_SEC(r.entrada)) >= (- TIME_TO_SEC(h.tolerancia)), '0' , (TIME_TO_SEC(h.entrada) - TIME_TO_SEC(r.entrada)) ) ) + IF( (TIME_TO_SEC(r.saida) - TIME_TO_SEC(h.saida)) > '-60' && (TIME_TO_SEC(r.saida) - TIME_TO_SEC(h.saida)) <= TIME_TO_SEC(h.tolerancia), '0' , IF( (TIME_TO_SEC(r.saida) - TIME_TO_SEC(h.saida)) < '-60' && (TIME_TO_SEC(r.saida) - TIME_TO_SEC(h.saida)) >= (- TIME_TO_SEC(h.tolerancia)), '0' , (TIME_TO_SEC(r.saida) - TIME_TO_SEC(h.saida)) ) ) ) AS banco FROM registro AS r, funcionario AS f, horario AS h WHERE r.matricula = f.matricula and r.matricula = ";
            string sql = sqlpart + string.Format("'{0}' and r.data BETWEEN '{1}' AND '{2}' and f.horario = h.descricao",
                matricula,
                datas[0],
                datas[2]);

            bool cabecalho = true;

            DataTable data;

            StreamWriter relatorio = new StreamWriter(@"relatorioBatidaIndividual.txt");



            try
            {
                data = conexao.getDados(sql);

                foreach(DataRow row in data.Rows)
                {
                    if (cabecalho)
                    {
                        relatorio.WriteLine("###########################################################################################");
                        relatorio.WriteLine("\t\t\t\t  RELATÓRIO DE BATIDAS INDIVIDUAL");
                        relatorio.WriteLine("===========================================================================================");
                        relatorio.WriteLine(string.Format("{0,-50}|{1,-35}", ("NOME: "+row["nome"].ToString()), ("MATRÍCULA: "+matricula)));
                        relatorio.WriteLine("===========================================================================================");
                        cabecalho = false;
                    }
                    relatorio.WriteLine(string.Format("{0,-22}|{1,-22}|{2,-22}|{3,-22}",
                        ("DATA: "+row["data"].ToString().Substring(0,10)),
                        ("ENTRADA: "+row["entrada"].ToString()),
                        ("SAÍDA: "+row["saida"].ToString()),
                        ("BANCO: " + row["banco"].ToString())));
                    relatorio.WriteLine("-------------------------------------------------------------------------------------------");
                }

                relatorio.WriteLine("###########################################################################################");
                relatorio.Close();
            }
            catch (Exception)
            { 
            }

            Process.Start(@"relatorioBatidaIndividual.txt");
        }

        public DataTable consultaFuncionario(Conexao conexao, Funcionario funcionario)
        {
            string sql = string.Format("SELECT matricula , nome FROM funcionario WHERE nome like '%{0}%'", funcionario.Nome);

            DataTable data;

            try
            {
                data = conexao.getDados(sql);

                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

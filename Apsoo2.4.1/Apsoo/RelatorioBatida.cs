using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace Apsoo
{
    class RelatorioBatida
    {
        public void batidas(Conexao conexao, string[] datas)
        {
            string sql = string.Format("SELECT f.nome, r.entrada, r.saida FROM funcionario AS f, registro AS r WHERE f.matricula = r.matricula and r.data = '{0}'", datas[0]);

            DataTable data;

            StreamWriter relatorio = new StreamWriter(@"relatorioPorDia.txt");

            relatorio.WriteLine("###########################################################################################");
            relatorio.WriteLine(string.Format("\t\t\t  RELATÓRIO DE BATIDAS DIA {0}",datas[1]));
            relatorio.WriteLine("===========================================================================================");
            relatorio.WriteLine(string.Format("{0,-50}|{1,-20}|{2,-20}", "NOME", "ENTRADA", "SAÍDA"));
            relatorio.WriteLine("===========================================================================================");

            try
            {
                data = conexao.getDados(sql);

                foreach(DataRow row in data.Rows)
                {
                    relatorio.WriteLine(string.Format("{0,-50}|{1,-20}|{2,-20}", 
                        row["nome"].ToString(), 
                        row["entrada"].ToString(), 
                        row["saida"].ToString()));
                    relatorio.WriteLine("-------------------------------------------------------------------------------------------");
                }
                relatorio.WriteLine("###########################################################################################");
                relatorio.Close();
            }
            catch (Exception)
            {
            }

            Process.Start(@"relatorioPorDia.txt");
        }
    }
}

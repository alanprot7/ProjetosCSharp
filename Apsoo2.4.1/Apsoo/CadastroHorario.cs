using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Apsoo
{
    class CadastroHorario
    {


        public void cadastrar(Conexao conexao, Horario horario)
        {

            string sql = string.Format("INSERT INTO horario VALUES ('{0}','{1}','{2}','{3}')",
                horario.Descricao,
                horario.HoraEntrada,
                horario.HoraSaida,
                horario.Tolerancia);
            try
            {
                if (conexao.setDados(sql) > 0)
                    MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }


        public void deletar(Conexao conexao, string descricao)
        {

            String sql = string.Format("DELETE FROM horario WHERE descricao='{0}'",descricao);


            try
            {

                if (conexao.setDados(sql) > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        public void atualizar(Conexao conexao, Horario horario)
        {

            string sql = string.Format("UPDATE horario SET entrada ='{0}', saida = '{1}', tolerancia = '{2}' WHERE descricao = '{3}'",
                horario.HoraEntrada,
                horario.HoraSaida,
                horario.Tolerancia,
                horario.Descricao);

            try
            {

                if (conexao.setDados(sql) > 0)
                    MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


        }


        public DataTable consultar(Conexao conexao, string descricao)
        {

            string sql = string.Format("SELECT * FROM horario WHERE descricao like '%{0}%'",descricao);
            DataTable data = null;

            try
            {

                data = conexao.getDados(sql);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }

            return data;


        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Apsoo
{
    class CadastroFucionario
    {
        public void cadastrar(Conexao conexao, Funcionario funcionario)
        {

            string sql = string.Format("INSERT INTO funcionario VALUES ({0},'{1}','{2}')",
                funcionario.Matricula,
                funcionario.Nome,
                funcionario.Horario);

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


        public void deletar(Conexao conexao, int matricula)
        {

            String sql = string.Format("DELETE FROM funcionario WHERE matricula = {0}", matricula);


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

        public void atualizar(Conexao conexao, Funcionario funcionario)
        {

            string sql = string.Format("UPDATE funcionario SET nome ='{0}', horario = '{1}' WHERE matricula = {2}",
                funcionario.Nome,
                funcionario.Horario,
                funcionario.Matricula);

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


        public DataTable consultar(Conexao conexao, string nome)
        {

            string sql = string.Format("SELECT * FROM funcionario WHERE nome like '%{0}%'", nome);
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

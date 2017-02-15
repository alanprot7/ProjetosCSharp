using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Apsoo
{
    class ControlePonto
    {
        private CadastroHorario cadastroHorario = new CadastroHorario();
        private ConfiguracaoControle configuracao = new ConfiguracaoControle();
        private RelatorioFuncionario relatorioFuncionario = new RelatorioFuncionario();
        private CadastroFucionario cadastroFuncionario = new CadastroFucionario();
        private RegistraPonto registraPonto = new RegistraPonto();
        private CarregaHorarioFuncionario carregaDescricaoFuncionario = new CarregaHorarioFuncionario();
        private RelatorioBatida relatorioBatida = new RelatorioBatida();
        private RelatorioBatidaIndividual relatorioBatidaIndividual = new RelatorioBatidaIndividual();
        private string senha;
        public Horario horario = new Horario();
        public Registro registro = new Registro();
        public Funcionario funcionario = new Funcionario();
        private Conexao conexao = new Conexao();

        public ControlePonto()
        {
            carregaSenha();
        }

        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }

        public void cadastrarHorario()
        {
            cadastroHorario.cadastrar(conexao, horario);
        }

        public void atualizarHoraio()
        {
            cadastroHorario.atualizar(conexao, horario);
        }

        public void excluirHorario()
        {
            cadastroHorario.deletar(conexao, horario.Descricao);
        }

        public DataTable consultaHorario()
        {
            return cadastroHorario.consultar(conexao, horario.Descricao);
        }

        public void cadastrarFuncionario()
        {
            cadastroFuncionario.cadastrar(conexao, funcionario);
        }

        public void atualizarFuncionario()
        {
            cadastroFuncionario.atualizar(conexao, funcionario);
        }

        public void excluirFuncionario()
        {
            cadastroFuncionario.deletar(conexao,funcionario.Matricula);
        }

        public DataTable consultarFuncionario()
        {
            return cadastroFuncionario.consultar(conexao, funcionario.Nome);
        }

        public void carregaSenha()
        {
           senha = configuracao.consulta(conexao);
        }

        public void cadastraSenha()
        {
            configuracao.cadastra(conexao, senha);
        }

        public void emitirRelatorioFuncionario()
        {
            relatorioFuncionario.geraRelatorioFuncionario(conexao);
        }

        public string registraBatida()
        {
           return registraPonto.registraPonto(conexao, registro);
            
        }

        public string[] carregaDropDowDescricaoFuncionario()
        {
            return carregaDescricaoFuncionario.carregar(conexao);
        }

        public void emitirRelatorioBatida(string[] datas)
        {
            relatorioBatida.batidas(conexao, datas);
        }

        public DataTable consultaFuncionarioIndividual()
        {
           return relatorioBatidaIndividual.consultaFuncionario(conexao, funcionario);
        }

        public void emitirRelatorioIndividual(string[] datas, string matricula)
        {
            relatorioBatidaIndividual.batidas(conexao, datas, matricula);
        }
  
    }
}

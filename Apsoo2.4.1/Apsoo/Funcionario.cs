using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apsoo
{
    class Funcionario
    {
        private int matricula;
        private string nome;
        private string horario;

        public int Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Horario
        {
            get
            {
                return horario;
            }
            set
            {
                horario = value;
            }
        }
    }
}

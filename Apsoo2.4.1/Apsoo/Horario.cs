using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apsoo
{
    class Horario
    {
        private string descricao;
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }

        }

        private string horaEntrada;
        public string HoraEntrada
        {
            get
            {
                return horaEntrada;
            }
            set
            {
                horaEntrada = value;
            }
        }

        private string horaSaida;
        public string HoraSaida
        {
            get
            {
                return horaSaida;
            }
            set
            {
                horaSaida = value;
            }
        }

        private string tolerancia;
        public string Tolerancia
        {
            get
            {
                return tolerancia;
            }
            set
            {
                tolerancia = value;
            }
        }
    }
}

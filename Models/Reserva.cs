using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Reserva
    {
        public Reserva() {}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes {get; set;}
        public Suite SuiteReservada { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes) {

            if (hospedes.Count <= SuiteReservada.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A suite não suporta essa quantidade de Hospedes!");
            }
        }

        public void CadastrarSuite(Suite suiteReservada) {
            this.SuiteReservada = suiteReservada;
        }

        public int ObterQuantidadeHospedes() {

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * SuiteReservada.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= 0.90M;
            }

            return valor;
        }
    }
}
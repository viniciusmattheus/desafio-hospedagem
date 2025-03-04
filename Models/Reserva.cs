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
            this.DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite { get; set; }
        
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes) {
        }

        public void CadastrarSuite(Suite suite) {
            this.Suite = suite;
        }

        public int ObterQuantidadeHospedes() {
            int quantidadeHospedes;

            if (Hospedes.Count != 0) 
            {
                quantidadeHospedes = Hospedes.Count;
                return quantidadeHospedes;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalcularValorDiaria()
        {
            return 0;
        }
    }
}
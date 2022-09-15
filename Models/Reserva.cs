namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado!!!!

            Hospedes = hospedes;

            if(Hospedes.Count > Suite.Capacidade)
            {
                throw new ArgumentException("Quantidade de hospodes maior que a capacidade");
            }
                
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // implementado!!!
           int hosp;
           hosp = Hospedes.Count;

           return hosp;
        }

        public decimal CalcularValorDiaria()
        {
            // implementado!!!
            decimal valor= 0;
            decimal desconto = (DiasReservados*Suite.ValorDiaria)*10/100;
            
            // Implementado!!!!

            if (DiasReservados >= 10)
            {
               valor = DiasReservados * Suite.ValorDiaria - desconto;
            }
            else
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }

            return valor;
        }
    }


}


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
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                // exceção de argumento
                throw new ArgumentException("Infelizmente a suite não tem capacidade suficiente.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int qtdHopesdes = Convert.ToInt32(Hospedes.Count());
            return qtdHopesdes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

        
            if (DiasReservados >= 10)
            {
                decimal valorComDesconto = valor * 0.10M;
                valor = valor - valorComDesconto;
            }

            return valor;
        }
    }
}
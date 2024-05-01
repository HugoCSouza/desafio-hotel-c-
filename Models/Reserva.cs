namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { 
            Console.WriteLine($"Reserva de {DiasReservados} dias cadastrada!\n");
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Console.WriteLine($"Reserva de {DiasReservados} dias cadastrada!\n");
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
                Console.WriteLine($"A reserva da suite {Suite.TipoSuite} foi realizada com sucesso!\n");
            }
            else
            {
                throw new Exception("A quantidade de hóspedes é maior que a capacidade da suíte!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
            Console.WriteLine($"A suite {Suite.TipoSuite} foi incorporada a reserva!\n");
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados*Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valor = valor * 0.9M;
            }

            return valor;
        }

        public void Resumo(){
            Console.WriteLine($"Resumo da reserva.\n" + 
                        $"\tTipo de suíte: {Suite.TipoSuite}\n " +
                        $"\tQuantidade de hóspedes: {ObterQuantidadeHospedes()}\n" +
                        $"\tCapacidade da suíte: {Suite.Capacidade}\n" +
                        $"\tDias reservados: {DiasReservados}\n" +
                        $"\tValor da diária: R${Suite.ValorDiaria.ToString("0.00")}\n" +
                        $"\tValor da reserva: R${CalcularValorDiaria().ToString("0.00")}\n\n\n");
}

    }
}
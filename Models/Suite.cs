namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
            Console.WriteLine("A suíte do tipo " + TipoSuite + $" foi criada!\nNela, é possivel alocar {Capacidade} hóspedes, custando R${ValorDiaria} por dia, sem desconto!\n");
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
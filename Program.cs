using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

// Criando hóspedes aleatórios
Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Jorge", sobrenome: "Paulo");
Pessoa p4 = new Pessoa(nome: "Lucas", sobrenome: "Xique");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suiteP = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite suiteB = new Suite(tipoSuite: "Basica", capacidade: 5, valorDiaria: 10);
Suite suiteM = new Suite(tipoSuite: "Master", capacidade: 4, valorDiaria: 50);
Suite suiteE = new Suite(tipoSuite: "Elite", capacidade: 10, valorDiaria: 150);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suiteP);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
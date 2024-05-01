using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
List<Pessoa> casal = new List<Pessoa>();

// Criando hóspedes aleatórios
Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Jorge", sobrenome: "Paulo");
Pessoa p4 = new Pessoa(nome: "Lucas", sobrenome: "Xique");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suiteC = new Suite(tipoSuite: "Casal", capacidade: 2, valorDiaria: 30);
Suite suiteB = new Suite(tipoSuite: "Basica", capacidade: 5, valorDiaria: 10);
Suite suiteM = new Suite(tipoSuite: "Master", capacidade: 4, valorDiaria: 50);
Suite suiteE = new Suite(tipoSuite: "Elite", capacidade: 10, valorDiaria: 150);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reservab = new Reserva(diasReservados: 5);
reservab.CadastrarSuite(suiteB);
reservab.CadastrarHospedes(hospedes);
reservab.Resumo();

Reserva reservac = new Reserva(diasReservados: 15);
casal.Add(p3);
casal.Add(p4);
reservac.CadastrarSuite(suiteC);
reservac.CadastrarHospedes(casal);
reservac.Resumo();

Reserva reservam = new Reserva(diasReservados: 3);
reservam.CadastrarSuite(suiteM);
reservam.CadastrarHospedes(hospedes);
reservam.Resumo();

hospedes.Add(p4);
Reserva reservae = new Reserva(diasReservados: 35);
reservae.CadastrarSuite(suiteE);
reservae.CadastrarHospedes(hospedes);
reservae.Resumo();

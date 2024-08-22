using system.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na \lista de hóspede

List<Pessoa> = hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suite

Suite suitePremium = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50);
//Suite suiteMaster = new Suite(tipoSuite: "Master", capacidade: 2, valorDiaria: 40);
//Suite suiteSolteiro = new Suite(tipoSuite: "Solteiro", capacidade: 1, valorDiaria: 30);

// Cria uma nova reserva, passando a suite e os hospedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suitePremium);
reserva.CadastrarHospedes(hospedes);

// Exibi a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da Diária: {reserva.CalcularValorDiaria()}");

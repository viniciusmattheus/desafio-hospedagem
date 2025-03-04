using Hospedagem.Models;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
List<Pessoa> hospedes1 = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Vinicius", sobrenome: "Matheus");
Pessoa p2 = new Pessoa(nome: "Matheus", sobrenome: "Vinicius");

Pessoa p3 = new Pessoa(nome: "Caroline", sobrenome: "Tavares");
Pessoa p4 = new Pessoa(nome: "Ingrid", sobrenome: "Tavares");
Pessoa p5 = new Pessoa(nome: "Vanda", sobrenome: "Tavares");

hospedes.Add(p1);
hospedes.Add(p2);

hospedes1.Add(p3);
hospedes1.Add(p4);
hospedes1.Add(p5);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50m);
Suite suite1 = new Suite(tipoSuite: "Luxo", capacidade: 3, valorDiaria: 80m);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new Reserva(diasReservados: 15);
reserva1.DiasReservados = 15;
reserva1.CadastrarSuite(suite1);
reserva1.CadastrarHospedes(hospedes1);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"Suite : {reserva.SuiteReservada.TipoSuite}");
Console.WriteLine($"Dias Reservados : {reserva.DiasReservados}");

Console.WriteLine("--------------------------------------");

Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva1.CalcularValorDiaria()}");
Console.WriteLine($"Suite : {reserva1.SuiteReservada.TipoSuite}");
Console.WriteLine($"Dias Reservados : {reserva1.DiasReservados}");

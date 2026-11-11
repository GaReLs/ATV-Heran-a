
using System.ComponentModel;
using ATV_Heranca;

// Carro c1 = new Carro();

// c1.Marca = "Honda";
// c1.Modelo = "civic";
// c1.QuantidadeDePortas = 4;

// c1.ExibirInformacoes();

// Motocicleta m1 = new Motocicleta();
// m1.Marca = "japa";
// m1.Modelo = "n sei";
// m1.Cilindradas = 6;
// m1.ExibirInformacoes();

// Ebook e1 = new Ebook("abc", 10m, 10);

// CursoOnline c1 = new CursoOnline("abc", 50m, 100);

// JogoFisico jf1 = new JogoFisico();
// jf1.PlataformaDoJogo = "playstation";
// jf1.Informacoes();

// JogoDigital id1 = new JogoDigital("xbox");
// id1.Informacoes();

// NotifacacaoEmail nm1 = new NotifacacaoEmail();

// NotificacaoPush np1 = new NotificacaoPush();

// NotificacaoSms ns1 = new NotificacaoSms();

// nm1.Enviar();
// np1.Enviar();
// ns1.Enviar();

// List<Entrega> entregas = new List<Entrega>();
// EntregaExpressa ex1 = new EntregaExpressa();
// EntregaEconomica ec1 = new EntregaEconomica();
// RetiradaNoLocal rl1 = new RetiradaNoLocal();
// ex1.Distancia = 40;
// ec1.Distancia = 40;
// rl1.Distancia = 0;

// entregas.Add(ex1);
// entregas.Add(ec1);
// entregas.Add(rl1);


// foreach (var item in entregas)
// {
//     item.CalcularFrete();
// }

Contrato contrato = new Contrato();
contrato.Imprimir();

Relatorio relatorio = new Relatorio();
relatorio.Imprimir();
relatorio.Exportar();



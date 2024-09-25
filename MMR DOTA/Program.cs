
Jogador Nim = new Jogador();
Nim.Vitorias = 10;
Nim.Nick = "Nim";
Nim.Derrotas = 5;
Nim.MMR = 1500;
Nim.Partidas = 15;

Jogador JDS = new Jogador();
JDS.Vitorias = 5;
JDS.Nick = "Firemind";
JDS.Derrotas = 10;
JDS.MMR = 1500;
JDS.Partidas = 15;

Jogador XIBA = new Jogador();
XIBA.Vitorias = 10;
XIBA.Nick = "Xibiu";
XIBA.Derrotas = 5;
XIBA.MMR = 1500;
XIBA.Partidas = 15;

Jogador FND = new Jogador();
FND.Vitorias = 5;
FND.Nick = "FND";
FND.Derrotas = 10;
FND.MMR = 1500;
FND.Partidas = 15;

Jogador Bulga = new Jogador();
Bulga.Vitorias = 10;
Bulga.Nick = "Bulga";
Bulga.Derrotas = 5;
Bulga.MMR = 1500;
Bulga.Partidas = 15;

Jogador Didigo = new Jogador();
Didigo.Vitorias = 10;
Didigo.Nick = "Didigo";
Didigo.Derrotas = 5;
Didigo.MMR = 1500;
Didigo.Partidas = 15;

Jogador Lavitz = new Jogador();
Lavitz.Vitorias = 10;
Lavitz.Nick = "Lavitz";
Lavitz.Derrotas = 5;
Lavitz.MMR = 1500;
Lavitz.Partidas = 15;

Jogador uri = new Jogador();
uri.Vitorias = 5;
uri.Nick = "uriel";
uri.Derrotas = 10;
uri.MMR = 1500;
uri.Partidas = 15;

Jogador gordao = new Jogador();
gordao.Vitorias = 5;
gordao.Nick = "f10";
gordao.Derrotas = 10;
gordao.MMR = 1500;
gordao.Partidas = 15;

Jogador Xips = new Jogador();
Xips.Vitorias = 5;
Xips.Nick = "Xips";
Xips.Derrotas = 10;
Xips.MMR = 1500;
Xips.Partidas = 15;

// mostrar o titulo tabela
// fazer tabela com os jogadores nome e mmr.
// atribuir valores para derrotas e vitorias
// mostrar a tabela em ordem decrescente de mmr


List<Jogador> players = new List<Jogador>();
players.Add(uri);
players.Add(gordao);
players.Add(Xips);
players.Add(Lavitz);
players.Add(FND);
players.Add(Nim);
players.Add(Didigo);
players.Add(Bulga);
players.Add(JDS);
players.Add(XIBA);

Console.WriteLine("TABELA MMR MLKADA");
foreach (var player in players)
{
    player.MMR += player.Vitorias * 30 - player.Derrotas * 30;
}

players = players.OrderByDescending(j => j.MMR).ToList();

foreach (var player in players)
{
    Console.WriteLine($"Jogador: {player.Nick} MMR: {player.MMR} Partidas: {player.Partidas} Vitórias: {player.Vitorias} Derrotas: {player.Derrotas}");
}




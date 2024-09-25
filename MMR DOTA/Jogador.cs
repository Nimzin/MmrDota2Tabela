

class Jogador
{
    public string Nick { get; set; }
    public int MMR { get; set; }
    public int Vitorias { get; set; }
    public int Derrotas { get; set; }
    public int Partidas { get; set; }


    public Jogador() 
    {
        
    
    }
    public Jogador(string nick, int mmr, int vitorias, int derrotas, int partidas)
    {
        Nick = nick;
        MMR = mmr;
        Vitorias = vitorias;
        Derrotas = derrotas;
        Partidas = partidas;
        
    }




} 



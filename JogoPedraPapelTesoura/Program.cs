namespace PedraPapelTesoura;

class Progra    
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool continuar = true;
        string jogador;
        string maquina;

        while (continuar)
        {
            jogador = "";
            maquina = "";

            Console.Write("Jogador (PEDRA/PAPEL/TESOURA): ");
            jogador = Console.ReadLine().ToUpper();

            switch (random.Next(1, 4))
            {
                case 1:
                    maquina = "PEDRA";
                    break;
                case 2:
                    maquina = "PAPEL";
                    break;
                case 3:
                    maquina = "TESOURA";
                    break;
            }

            Console.WriteLine($"Jogador = {jogador}");
            Console.WriteLine($"Máquina = {maquina}");

            switch (jogador)
            {
                case "PEDRA":
                    if(maquina == "PAPEL")
                    {
                        Console.WriteLine("Máquina ganhou!");
                    }
                    else if(maquina == "PEDRA")
                    {
                        Console.WriteLine("Empate!");
                    }
                    else
                    {
                        Console.WriteLine("Jogador ganhou!");
                    }
                    break;

                case "PAPEL":
                    if(maquina == "TESOURA")
                    {
                        Console.WriteLine("Máquina ganhou!");
                    }
                    else if(maquina == "PAPEL")
                    {
                        Console.WriteLine("Empate!");
                    }
                    else
                    {
                        Console.WriteLine("Jogador ganhou!");
                    }
                    break;

                case "TESOURA":
                    if(maquina == "PEDRA")
                    {
                        Console.WriteLine("Máquina ganhou!");
                    }
                    else if(maquina == "TESOURA")
                    {
                        Console.WriteLine("Empate!");
                    }
                    else
                    {
                        Console.WriteLine("Jogador ganhou!");
                    }
                    break;
            }
            Console.Write("Deseja continuar jogando? (S/N): ");
            string opcao = Console.ReadLine().ToUpper();
            if( opcao == "N")
            {
                continuar = false;
            }
            else
            {
                continuar = true;
            }
        }
    }

        
}
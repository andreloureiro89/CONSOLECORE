using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador{
        public string Chuta(){
           return "Maradona chuta a bola\n";
        }

        public string Corre(){
           return "Maradona está a correr\n";
        }

        public string Passe(){
           return "Maradona passou a bola\n";
        }
    }
}
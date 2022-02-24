using System;
using RPGOOPDIO.src.entities;

namespace RPGOOPDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem arus = new Personagem(
                "Arus", 42, "Guerreiro"
            );

            Console.WriteLine(arus.ToString());
        }
    }
}

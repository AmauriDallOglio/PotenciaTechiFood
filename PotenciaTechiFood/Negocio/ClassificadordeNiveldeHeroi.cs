﻿namespace PotenciaTechiFood.Negocio
{
    public class ClassificadordeNiveldeHeroi
    {
        public void Executar()
        {
            Console.WriteLine($"Digite o nome do herói!");
            var nome = Console.ReadLine();
            Console.WriteLine($"Digite o xp!");
            var xp = int.Parse(Console.ReadLine());


            var nivel = "";

            if (xp < 1000)
            {
                nivel = "Ferro";
            }
            else if (xp >= 1001 && xp <= 2000)
            {
                nivel = "Bronze";
            }
            else if (xp >= 2001 && xp <= 5000)
            {
                nivel = "Prata";
            }
            else if (xp >= 6001 && xp <= 7000)
            {
                nivel = "Ouro";
            }
            else if (xp >= 7001 && xp <= 8000)
            {
                nivel = "Platina";
            }
            else if (xp >= 8001 && xp <= 9000)
            {
                nivel = "Ascendente";
            }
            else if (xp >= 9001 && xp <= 10000)
            {
                nivel = "Imortal";
            }
            else
            {
                nivel = "Radiante";
            }

            // Saída
            Console.WriteLine($"O Herói {nome} está no nível de {nivel}");
        }


        public class Heroi
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Tipo { get; set; }
 
        }

        public void ExecutarHeroi()
        {
           

            Console.WriteLine($"Digite o nome do herói!");
            var nome = Console.ReadLine();
            Console.WriteLine($"Digite a idade!");
            var idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o tipo!");
            var tipo = Console.ReadLine();

            Heroi heroi = new Heroi() { Idade = idade, Nome = nome, Tipo = tipo };
            Atacar(heroi);

        }

        public void Atacar(Heroi heroi)
        {
            string ataque = ""; // Variável para armazenar a descrição do ataque

            switch (heroi.Tipo)
            {
                case "mago":
                    ataque = "magia"; // Ataque do mago
                    break;
                case "guerreiro":
                    ataque = "espada"; // Ataque do guerreiro
                    break;
                case "monge":
                    ataque = "artes marciais"; // Ataque do monge
                    break;
                case "ninja":
                    ataque = "shuriken"; // Ataque do ninja
                    break;
                default:
                    ataque = "não possui ataque definido"; // Valor padrão caso o tipo não seja reconhecido
                    break;
            }

            // Imprime a mensagem do ataque
            Console.WriteLine($"O {heroi.Tipo} atacou usando {ataque}");
        }
    }
}

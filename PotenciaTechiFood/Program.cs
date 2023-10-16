

using PotenciaTechiFood.Negocio;
using static PotenciaTechiFood.Negocio.ClassificadordeNiveldeHeroi;

ClassificadordeNiveldeHeroi classificadordeNiveldeHeroi = new ClassificadordeNiveldeHeroi();
classificadordeNiveldeHeroi.Executar();


Heroi heroi1 = new Heroi("Herói 1", 30, "mago"); // Criação de uma instância de herói (objeto)
Heroi heroi2 = new Heroi("Herói 2", 25, "guerreiro"); // Criação de outra instância de herói

heroi1.Atacar(); // Chamada do método de ataque para o primeiro herói
heroi2.Atacar(); // Chamada do método de ataque para o segundo herói

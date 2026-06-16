using UnityEngine;

public class TesteDeClasses : MonoBehaviour
{

    void Start()
    {
        Pokemon bulbasauro = new Pokemon(1, "Bulbasauro", 50, 5, 5);
        Pokemon ivysauro = new Pokemon(2, "Ivysauro", 70, 7, 7);
        Pokemon venosauro = new Pokemon(3, "Venosauro", 100, 10, 10);
        Pokemon charmander = new Pokemon(4, "Charmander", 30, 7, 3);
        Pokemon charmileon = new Pokemon(5, "Charmeleon", 60, 12, 6);
        Pokemon charizard = new Pokemon(6, "Charizard", 90, 20, 9);
        Pokemon squirtle = new Pokemon(7, "Squirtle", 70, 3, 7);
        Pokemon wartortle = new Pokemon(8, "Wartortle", 120, 6, 12);
        Pokemon blastoise = new Pokemon(9, "Blastoise", 200, 9, 20);

        bulbasauro.SetEvolucao(ivysauro);
        ivysauro.SetEvolucao(venosauro);
        charmander.SetEvolucao(charmileon);
        charmileon.SetEvolucao(charizard);
        squirtle.SetEvolucao(wartortle);
        wartortle.SetEvolucao(blastoise);

        PokemonItemPorcao porcaoNormal = new PokemonItemPorcao(5);
        PokemonItemPorcao porcaoSuper = new PokemonItemPorcao(20);
        PokemonItemPorcao porcaoUltra = new PokemonItemPorcao(50);

        PokemonBatalha pokemonBatalha1 = new PokemonBatalha(charizard);
        PokemonBatalha pokemonBatalha2 = new PokemonBatalha(venosauro);

        int rodada = 0;

        // Rodada 1
        rodada++;
        pokemonBatalha1.Ataca(pokemonBatalha2);
        ImprimeDadosDeBatalha(rodada, pokemonBatalha1, pokemonBatalha2);

        // Rodada 2
        rodada++;
        pokemonBatalha1.Ataca(pokemonBatalha2);
        ImprimeDadosDeBatalha(rodada, pokemonBatalha1, pokemonBatalha2);

        // Rodada 3
        rodada++;
        pokemonBatalha1.Ataca(pokemonBatalha2);
        ImprimeDadosDeBatalha(rodada, pokemonBatalha1, pokemonBatalha2);

        // Rodada 4
        rodada++;
        porcaoNormal.Usar(pokemonBatalha2);
        ImprimeDadosDeBatalha(rodada, pokemonBatalha1, pokemonBatalha2);

        // Rodada 5
        rodada++;
        pokemonBatalha1.Ataca(pokemonBatalha2);
        ImprimeDadosDeBatalha(rodada, pokemonBatalha1, pokemonBatalha2);

        // Rodada 6
        rodada++;
        pokemonBatalha1.Ataca(pokemonBatalha2);
        ImprimeDadosDeBatalha(rodada, pokemonBatalha1, pokemonBatalha2);

        // Rodada 7
        rodada++;
        pokemonBatalha1.Ataca(pokemonBatalha2);
        ImprimeDadosDeBatalha(rodada, pokemonBatalha1, pokemonBatalha2);

        // Rodada 8
        rodada++;
        pokemonBatalha1.Ataca(pokemonBatalha2);
        ImprimeDadosDeBatalha(rodada, pokemonBatalha1, pokemonBatalha2);

        // Rodada 9
        rodada++;
        porcaoUltra.Usar(pokemonBatalha2);
        ImprimeDadosDeBatalha(rodada, pokemonBatalha1, pokemonBatalha2);
    }

    private void ImprimeDadosDeBatalha(int rodada, PokemonBatalha pokemonBatalha1, PokemonBatalha pokemonBatalha2)
    {
        Debug.Log("================= Rodada " + rodada + " =================");
        pokemonBatalha1.ImprimeDadosDeBatalha();
        pokemonBatalha2.ImprimeDadosDeBatalha();
    }

    private void TesteDeAnimais()
    {
        Animal animal1 = null;
        Animal animal2 = new Animal("Rex");
        AnimalTerrestre animalTerrestre = new AnimalTerrestre();
        Cachorro cachorro = new Cachorro();
        Gato gato = new Gato();
        Humano humano1 = new Humano();
        Humano humano2 = new Humano();

        // animalTerrestre.nome = "animal T 1";

        // humano1.nome = "Alex";
        humano1.altura = 1.75f;
        humano1.cpf = "111.111.111-11";

        // Debug.Log("Animal Terrestre: " + animalTerrestre.nome);
        // animal.Crescer();
        // animalTerrestre.Crescer();
        // animalTerrestre.FazerBarulho();
        // cachorro.Crescer();
        // cachorro.Latir();
        // gato.Crescer();
        // humano1.Crescer();
        // humano1.Trabalhando();
        // humano2.Crescer();
        // humano2.Trabalhando();

        Debug.Log("Animal1: " + animal1.GetNome());
    }

}

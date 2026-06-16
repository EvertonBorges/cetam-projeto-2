using UnityEngine;

public class Cachorro : AnimalTerrestre
{

    public string raca;
    
    public void Latir()
    {
        Debug.Log("Cachorro " + nome + " (raça = " + raca + ") está latindo...");
    }

}

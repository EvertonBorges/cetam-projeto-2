using UnityEngine;

public class Humano : AnimalTerrestre
{

    public string cpf;
    public float altura;
    
    public void Trabalhando()
    {
        Debug.Log("Olá, sou o " + nome + " e estou trabalhando...");
        Debug.Log("Meu cpf é: " + cpf);
        Debug.Log("Minha altura é de : " + altura + "m");
    }

}

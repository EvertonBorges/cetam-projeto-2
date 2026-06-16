using UnityEngine;

public class Animal
{
    
    protected string nome;

    public Animal()
    {
        nome = "Animal Padrão";
    }

    public Animal(string novoNome)
    {
        nome = novoNome;
    }

    public void Crescer()
    {
        Debug.Log("Animal crescendo...");
    }

    public string GetNome()
    {
        return nome;
    }

}

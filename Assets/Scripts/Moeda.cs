using UnityEngine;

public class Moeda : MonoBehaviour
{

    public ControladorDeMoedas controladorDeMoedas;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            controladorDeMoedas.MoedaColetada();
            Destroy(gameObject);
        }
    }

}

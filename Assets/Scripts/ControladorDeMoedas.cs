using UnityEngine;
using TMPro;

public class ControladorDeMoedas : MonoBehaviour
{
    
    public TextMeshProUGUI text;

    private int moedas = 0;

    void Start()
    {
        text.SetText("5");
    }

    public void MoedaColetada()
    {
        moedas++;
        text.SetText("" + moedas);
    }

}

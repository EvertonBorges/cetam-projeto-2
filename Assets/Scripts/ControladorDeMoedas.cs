using UnityEngine;
using TMPro;

public class ControladorDeMoedas : MonoBehaviour
{
    
    public TextMeshProUGUI text;

    private int moedas = 0;

    public void MoedaColetada()
    {
        moedas++;
        text.SetText("" + moedas);
    }

}

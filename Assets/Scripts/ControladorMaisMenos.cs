using TMPro;
using UnityEngine;

public class ControladorMaisMenos : MonoBehaviour
{

    public TextMeshProUGUI texto;
    private int valor = 0;
    
    public void BTN_Mais()
    {
        valor++;
        AtualizarUI();
    }

    public void BTN_Menos()
    {
        valor--;
        AtualizarUI();
    }

    private void AtualizarUI()
    {
        texto.SetText(valor.ToString());
    }

}

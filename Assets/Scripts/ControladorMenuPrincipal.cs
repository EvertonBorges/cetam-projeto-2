using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenuPrincipal : MonoBehaviour
{
    
    public void BTN_Jogar()
    {
        SceneManager.LoadScene("SCN_Game");
    }

    public void BTN_Sair()
    {
        EditorApplication.ExitPlaymode();
    }

}

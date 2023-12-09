using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    
    // aloita peli painike hypp‰‰ kuva23 kahvihuoneeseen.
    public void AloitusBtnClicked()
    {
        SceneManager.LoadScene("AMK_23_Kolmas_lansiKahvihuone");
    }

    // pois pelist‰
    public void LopetusBtnClicked()
    {
        Application.Quit();
    }
}

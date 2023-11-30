using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

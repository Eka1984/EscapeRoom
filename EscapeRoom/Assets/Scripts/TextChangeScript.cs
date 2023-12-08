using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextChangeScript : MonoBehaviour
{
    public Button ExitGame;
    public TextMeshProUGUI panelText;

    void Start()
    {
        ExitGame.interactable = false;
        //Aloitetaan coroutine 
        StartCoroutine(ChangeTextAfterDelay(5f));
    }

    IEnumerator ChangeTextAfterDelay(float delay)
    {
        // Odotetaan määriteltyä aikaa
        yield return new WaitForSeconds(delay);

        // Vaihdetaan teksti
        if (panelText != null)
        {
            panelText.text = "Nyt on aika rentoutua \nja \nsuunnata joululomalle! \n\nHyvää Joulua!<3";
            ExitGame.interactable = true;
        }


    }
    public void LopetusBtnClicked()
    {
        Application.Quit();
    }
}

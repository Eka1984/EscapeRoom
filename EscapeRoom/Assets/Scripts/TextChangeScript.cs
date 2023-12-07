using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextChangeScript : MonoBehaviour
{
    public TextMeshProUGUI panelText;

    void Start()
    {
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
        }
    }
}

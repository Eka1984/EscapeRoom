using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene23UI : MonoBehaviour
{
    public GameObject storyPanel;

    //Funktio, joka sulkee tarina-panelin
    public void SuljeButtonClicked()
    {
        storyPanel.SetActive(false);
    }
}

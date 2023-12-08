using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene23UI : MonoBehaviour
{
    public GameObject storyPanel;
    public void SuljeButtonClicked()
    {
        storyPanel.SetActive(false);
    }
}

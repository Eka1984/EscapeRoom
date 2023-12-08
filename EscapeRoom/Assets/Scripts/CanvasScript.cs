using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public GameObject exitButton;
    //public GameObject answerButton1;
    //public GameObject answerButton2;
    //public GameObject answerButton3;
    public TextMeshProUGUI feedBack;
    public GameObject questionPanel;

    
    // Start is called before the first frame update
    void Start()
    {
        exitButton.SetActive(false);
    }

    public void ChoiceOption1()
    {
        Debug.Log("Button Clicked!");
        feedBack.text = "Väärin! Yritä uudelleen";
        
    }
    public void ChoiceOption2()
    {        
        feedBack.text = "Oikein! Nyt voit poistua huoneesta";
        //feedBack.color = Color.blue;
        Invoke("ShowAnimation", 1.5f);
        Invoke("DeactivatePanel", 2.2f);
        exitButton.SetActive(true);
        
    }

    public void ChoiceOption3()
    {
        feedBack.text = "Väärin! Yritä uudelleen";
    }

    public void ShowAnimation()
    {
        questionPanel.GetComponent<Animator>().Play("PanelSlidesAway");
    }
    
    public void DeactivatePanel()
    {
        questionPanel.SetActive(false); 
    }
}

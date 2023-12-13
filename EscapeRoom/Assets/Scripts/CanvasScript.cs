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

    
    // Piilotetaan exit-objekti
    void Start()
    {
        exitButton.SetActive(false);
    }

    //Funktio, joka antaa väärin palaute
    public void ChoiceOption1()
    {
        //Debug.Log("Button Clicked!");
        feedBack.text = "Väärin! Yritä uudelleen";
        
    }

    //Funktio, joka antaa oikein palaute
    public void ChoiceOption2()
    {        
        feedBack.text = "Oikein! Nyt voit poistua huoneesta";
        //feedBack.color = Color.blue;
        Invoke("ShowAnimation", 1.5f);
        Invoke("DeactivatePanel", 2.2f);
        exitButton.SetActive(true);
        
    }
    //Funktio, joka antaa väärin palaute
    public void ChoiceOption3()
    {
        feedBack.text = "Väärin! Yritä uudelleen";
    }

    //Funktio, joka näyttää animaatiota
    public void ShowAnimation()
    {
        questionPanel.GetComponent<Animator>().Play("PanelSlidesAway");
    }
    
    //Funktio, joka deaktivoi kysymyspaneelin 
    public void DeactivatePanel()
    {
        questionPanel.SetActive(false); 
    }
}

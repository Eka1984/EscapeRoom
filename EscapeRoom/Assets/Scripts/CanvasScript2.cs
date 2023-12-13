using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasScript2 : MonoBehaviour
{
    public GameObject exitButton;
    public Button answerButton1;
    public Button answerButton2;
    public Button answerButton3;
    public TextMeshProUGUI feedBack;
    public GameObject questionPanel;


    // Start is called before the first frame update
    void Start()
    {
        //Piilotetaan exit-objekti
        exitButton.SetActive(false);

        //Lisätään listener ja funktioiden kutsu painikkeille
        answerButton1.onClick.AddListener(ChoiceOption1);
        answerButton2.onClick.AddListener(ChoiceOption2);
        answerButton3.onClick.AddListener(ChoiceOption3);
    }

    //Funktio,joka antaa väärin palaute
    public void ChoiceOption1()
    {
        //Debug.Log("Button Clicked!");
        feedBack.text = "Väärin! Yritä uudelleen";

    }
    //Funktio,joka antaa väärin palaute
    public void ChoiceOption2()
    {
       feedBack.text = "Väärin! Yritä uudelleen";  
        
    }

    //Funktio,joka antaa oikein palaute
    public void ChoiceOption3()
    {
        feedBack.text = "Oikein! Nyt voit poistua huoneesta";
        //feedBack.color = Color.blue;
        Invoke("ShowAnimation2", 1.5f);
        Invoke("DeactivatePanel", 2.2f);
        exitButton.SetActive(true);
        
    }
    //Funktio, joka näyttää animaatiota 
    public void ShowAnimation2()
    {
        questionPanel.GetComponent<Animator>().Play("PanelSlidesAwayToLeft");
    }

    //Funktio, joka deaktivoi kysymyspanelin
    public void DeactivatePanel()
    {
        questionPanel.SetActive(false);
    }
}

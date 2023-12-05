using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // T‰m‰ on lis‰tty tekstin kirjoiituksen varten


public class MultiChoiceQuetions: MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public GameObject btn1;    
    public GameObject btn2;
    public GameObject btn3;
    public int answer;
    public int oikeinVastaus = 2;
    public Renderer exitPicture;
    public Collider exitPictureCollider;
    public GameObject info;
    public GameObject quetion;

    private void Start()
    {
        // exit kuva ei ole n‰kyviss‰
        exitPicture.enabled = false;
        exitPictureCollider.enabled = false;

        // animaatio esille
        if(info != null)
        {
            info.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        // vastaus on v‰‰rin niin painikkeet eiv‰t h‰vi 
        if (answer != oikeinVastaus)
        {
            btn1.SetActive(true);
            btn2.SetActive(true);
            btn3.SetActive(true);
        }  
        // vastaus on oikein
        else if(answer == oikeinVastaus)
        {
            btn1.SetActive(false);
            btn2.SetActive(false);
            btn3.SetActive(false);
            quetion.SetActive(false);
            
            // exitkuva tulee esille
            exitPicture.enabled = true;
            exitPictureCollider.enabled = true;
        }

    }

    // tiet‰m‰tt‰ kertomusta painike
    public void btn1Clicked()
    {
        textBox.text = "Vastaus on v‰‰rin!";
        answer = 1;
    }

    // kameran edess‰ ujo painike
    public void btn2Clicked()
    {
        textBox.text = "Vastaus on oikein! Saat jatkaa seuraavalle!!";
        answer = 2;

    }

    // h‰nen kouluntapansa painike
    public void btn3Clicked()
    {
        textBox.text = "Vastaus on v‰‰rin!";
        answer = 3;
    }
}

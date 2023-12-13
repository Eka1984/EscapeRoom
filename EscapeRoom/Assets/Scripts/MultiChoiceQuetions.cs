using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; 


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
    public GameObject AnswerAnim;

    private void Start()
    {
        // exit kuva ei ole n‰kyviss‰
        exitPicture.enabled = false;
        exitPictureCollider.enabled = false;
        

        // vain infon animaatio esille
        if(info != null)
        {
            info.SetActive(true);
           
            // Vastauksen animaatio ei k‰ynnist‰
            AnswerAnim.GetComponent<Animator>().Play("ToWait");
        }

    }

    // Update is called once per frame
    void Update()
    {
        // vastaus on v‰‰rin niin painikkeet eiv‰t h‰vi‰ 
        if (answer != oikeinVastaus)
        {
            btn1.SetActive(true);
            btn2.SetActive(true);
            btn3.SetActive(true);

            // Vastauksen animaatio ei k‰ynnist‰
            AnswerAnim.GetComponent<Animator>().Play("ToWait");
        }  

        // vastaus on oikein. Btn ja kysymys paneeli menee piiloon ja lis‰ksi animmatio ilmestyy
        else if(answer == oikeinVastaus)
        {
            btn1.SetActive(false);
            btn2.SetActive(false);
            btn3.SetActive(false);
            quetion.SetActive(false);
            
            // exitkuva tulee esille
            exitPicture.enabled = true;
            exitPictureCollider.enabled = true;

            // vastauksen animaatio k‰ynnistyy
            AnswerAnim.GetComponent<Animator>().Play("ToHidden");
        }

    }

    // H‰n miettii joululomaa painike
    public void btn1Clicked()
    {
        textBox.text = "Vastaus on v‰‰rin!";
        answer = 1;
    }

    // kameran edess‰ ujo painike
    public void btn2Clicked()
    {
        textBox.text = "Vastaus on oikein! \nVoit jatkaa eteenp‰in!";
        answer = 2;
    }

    // H‰n koodaa samalla painike
    public void btn3Clicked()
    {
        textBox.text = "Vastaus on v‰‰rin!";
        answer = 3;       
    }
}

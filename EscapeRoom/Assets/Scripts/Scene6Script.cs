using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scene6Script : MonoBehaviour
{
    public TextMeshProUGUI textBox;    
    public Renderer exitPicture;
    public Collider exitPictureCollider;    
    public GameObject bt1;
    public GameObject bt2;
    public GameObject bt3;
    public int answer;
    public int oikeinVastaus = 2;    
    public GameObject quetion;
    public GameObject onnittelutTxt;
    public GameObject panel;   


    // Start is called before the first frame update
    void Start()
    {
        // exit kuva ei ole n‰kyville
        exitPicture.enabled = false;
        exitPictureCollider.enabled = false;
        
        // animaatio ei n‰kyville, joka ilmestyy kun vastaus on oikein
        onnittelutTxt.GetComponent<Animator>().Play("Wait");
    }

    // Update is called once per frame
    void Update()
    {
        // vastaus on v‰‰rin 
        if (answer != oikeinVastaus)
        {
            // vastauksen vaihtoehdot ovat esille
            bt1.SetActive(true);
            bt2.SetActive(true);
            bt3.SetActive(true);
            onnittelutTxt.GetComponent<Animator>().Play("Wait");
        }
        // vastaus on oikein
        else if(answer == oikeinVastaus)
        {
            // vastauksen vaihtoehdot menev‰t piiloon
            bt1.SetActive(false);
            bt2.SetActive(false);
            bt3.SetActive(false);
            quetion.SetActive(false);
            panel.SetActive(false);          

            // exitkuva tulee esille
            exitPicture.enabled = true;
            exitPictureCollider.enabled = true;

            // animaatio ilmestyy
            onnittelutTxt.GetComponent<Animator>().Play("Onnittelut_Panel");
            
        }
    }

    // funktio vastaus Btn1
    public void btn1Clicked()
    {
        textBox.text = "Vastaus on v‰‰rin!";
        answer = 0;
    }

    // funktio vastaus Btn2
    public void btn2Clicked()
    {
        textBox.text = "Vastaus on v‰‰rin!";
        answer = 1;
    }

    // funktio vastaus Btn3
    public void btn3Clicked()
    {
        textBox.text = "Vastaus on oiekin!";        
        answer = 2;

    }
}

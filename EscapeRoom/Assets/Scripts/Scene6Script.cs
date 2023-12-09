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
    //public Animator onnittelutPanelAnimator;
    //bool hasPlayedAnimation;



    // Start is called before the first frame update
    void Start()
    {
        exitPicture.enabled = false;
        exitPictureCollider.enabled = false;

        //onnittelutPanelAnimator = GetComponent<Animator>();
        //hasPlayedAnimation = false;

        onnittelutTxt.GetComponent<Animator>().Play("Wait");

        //Animator onnittelutPanelAnimator = onnittelutTxt.GetComponent<Animator>();
        //if (onnittelutPanelAnimator != null)
        //{
        //    Debug.Log("Start: Current Animation State: " + onnittelutPanelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash);
        //}
        //else
        //{
        //    Debug.LogError("Animator component not found on Onnittelut_Panel GameObject.");
        //}
        //projektiTxt.GetComponent<Animator>().Play("Project");s

        //onnittelutPanelAnimator = GetComponent<Animator>();

        //if (onnittelutPanelAnimator == null)
        //{
        //    Debug.LogError("Animator component not found on Onnittelut_Panel GameObject.");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (answer != oikeinVastaus)
        {
            bt1.SetActive(true);
            bt2.SetActive(true);
            bt3.SetActive(true);
            onnittelutTxt.GetComponent<Animator>().Play("Wait");
        }
        else if(answer == oikeinVastaus)
        {
            bt1.SetActive(false);
            bt2.SetActive(false);
            bt3.SetActive(false);
            quetion.SetActive(false);
            panel.SetActive(false);
            //onnittelutTxt.SetActive(true); //onnittelutTxt.transform.SetSiblingIndex(0);  
            

            // exitkuva tulee esille
            exitPicture.enabled = true;
            exitPictureCollider.enabled = true;

            onnittelutTxt.GetComponent<Animator>().Play("Onnittelut_Panel");
            //if(hasPlayedAnimation == false)
            //{
            //    onnittelutPanelAnimator.SetBool("hasPlayedAnimation", false);
            //}
            //if (hasPlayedAnimation == true)
            //{
            //    onnittelutPanelAnimator.SetBool("hasPlayedAnimation", true);
            //}


            //onnittelutTxt.GetComponent<Animator>().Play("Onnittelut_Panel");

            //Animator onnittelutPanelAnimator = onnittelutTxt.GetComponent<Animator>();
            //if (onnittelutPanelAnimator != null)
            //{
            //    Debug.Log("Update: Current Animation State: " + onnittelutPanelAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash);
            //    onnittelutPanelAnimator.Play("Onnittelut_Panel");
            //    //hasPlayedAnimation = true; // Set the flag to true to prevent re-triggering the animation
            //    Debug.Log("Animation Played!");
            //}
            //else
            //{
            //    Debug.LogError("Animator component not found on Onnittelut_Panel GameObject.");
            //}
        }
    }

    public void btn1Clicked()
    {
        textBox.text = "Vastaus on v‰‰rin!";
        answer = 0;
    }

    public void btn2Clicked()
    {
        textBox.text = "Vastaus on v‰‰rin!";
        answer = 1;
    }

    public void btn3Clicked()
    {
        textBox.text = "Vastaus on oiekin!";        
        answer = 2;

    }
}

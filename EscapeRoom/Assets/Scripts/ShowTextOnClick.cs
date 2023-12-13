using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ShowTextOnClick : MonoBehaviour
{
    public GameObject bio;
    // Piilotetaan opettaja bio alussa 
    void Start()
    {
        if (bio != null)
        {
            bio.SetActive(false);
        }
    }
    //Näytetään opettaja bio, kun kuva on klikattu 
    private void OnMouseDown()
    {
        bio.SetActive(true);

    }

}

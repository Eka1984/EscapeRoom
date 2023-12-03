using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ShowTextOnClick : MonoBehaviour
{
    public GameObject bio;
    // Start is called before the first frame update
    void Start()
    {
        if (bio != null)
        {
            bio.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        bio.SetActive(true);

    }

}

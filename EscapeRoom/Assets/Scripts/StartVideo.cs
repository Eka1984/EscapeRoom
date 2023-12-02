using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class StartVideo : MonoBehaviour
{
    
    public GameObject VideoPlane;

    // Start is called before the first frame update
    void Start()
    {
        if (VideoPlane != null)
        {
            VideoPlane.SetActive(false);
        }
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        VideoPlane.SetActive(true);
        
    }
}

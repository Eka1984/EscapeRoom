using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PauseVideoOnLoad : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

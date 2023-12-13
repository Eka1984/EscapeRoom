using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PauseVideoOnLoad : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    
    // Video keskeytetään heti latauksen jälkeen
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Pause();
    }
    
}

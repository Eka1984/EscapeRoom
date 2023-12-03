using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the VideoPlayer component
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.errorReceived += VideoPlayerErrorReceived;
    }

    void OnMouseDown()
    {    
        
        // Tarkistetaan soittaako video
        if (videoPlayer.isPlaying)
        {
            // Jos soitaa, lopetetaan
            videoPlayer.Pause();
        }
        else
        {
            // Jos ei soita, aloitetaan 
            videoPlayer.Play();
        }
    }

    void VideoPlayerErrorReceived(VideoPlayer source, string message)
    {
        Debug.LogError("VideoPlayer error: " + message);
    }
}

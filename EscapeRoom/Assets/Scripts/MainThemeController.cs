using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainThemeController : MonoBehaviour
{
    private AudioSource audioSource;
    private VideoPlayer videoPlayer;

    
    private void Start()
    {
        
        DontDestroyOnLoad(gameObject);
        
        audioSource = GetComponent<AudioSource>();
        
        audioSource.Play();               
        
    }

    private void Update()
    {
        videoPlayer = FindObjectOfType<VideoPlayer>();

        int lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        if (SceneManager.GetActiveScene().buildIndex == lastSceneIndex)
        {
            StopMusic();
        }

        if (videoPlayer != null)
        {
            videoPlayer.started += VideoStarted;
            videoPlayer.loopPointReached += VideoStopped;

            if (videoPlayer.isPaused)
            {
                VideoPaused(videoPlayer);
            }
        }

        if (videoPlayer == null || ReferenceEquals(videoPlayer, null))
        {
            ResumeMusic();
        }
    }

    private void StopMusic()
    {       
        audioSource.Stop();
    }

    private void VideoStarted(VideoPlayer vp)
    {        
        audioSource.Pause();        
    }

    private void VideoStopped(VideoPlayer vp)
    {
        ResumeMusic();
    }

    private void VideoPaused(VideoPlayer vp)
    {                  
       ResumeMusic();        
    }

    private void ResumeMusic()
    {        
        audioSource.UnPause();        
    }  

}


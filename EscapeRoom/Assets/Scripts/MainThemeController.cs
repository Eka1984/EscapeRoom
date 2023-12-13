using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainThemeController : MonoBehaviour
{
    private AudioSource audioSource;
    private VideoPlayer videoPlayer;

    
    //Saadaan AudioSource komponentti, tehdään siitä DontDestroyOnLoad ja aloitetaan musiikin soittoa 
    private void Start()
    {
        
        DontDestroyOnLoad(gameObject);
        
        audioSource = GetComponent<AudioSource>();
        
        audioSource.Play();               
        
    }

    private void Update()
    {
        //Tarkistetaan onko VideoPlayer objektti olemassa ja laitetaan se muuttujaan
        videoPlayer = FindObjectOfType<VideoPlayer>();

        //Tarkistetaan onko nykyinen scene viimeinen
        int lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        if (SceneManager.GetActiveScene().buildIndex == lastSceneIndex)
        //Jos on viimeinen, lopetetaan main theme musiikki
        {
            StopMusic();
        }

        //Jos scenessa on VideoPlayer komponentti 
        if (videoPlayer != null)
        {
            //Jos video soittaa, kutsutaan VideoStarted funktio 
            videoPlayer.started += VideoStarted;
            //Jos video on loppu, kutsutaan VideoStopped funktio 
            videoPlayer.loopPointReached += VideoStopped;

            //Jos video on keskeytetty, kutsutaan VideoPaused funktio 
            if (videoPlayer.isPaused)
            {
                VideoPaused(videoPlayer);
            }
        }

        //Jos VideoPlayer ei ole olemassa scenessa, aloitetaan musiikki
        if (videoPlayer == null || ReferenceEquals(videoPlayer, null))
        {
            ResumeMusic();
        }
    }

    //Pysäytetään musiikki
    private void StopMusic()
    {       
        audioSource.Stop();
    }

    //Keskeytetään musiikki
    private void VideoStarted(VideoPlayer vp)
    {        
        audioSource.Pause();        
    }

    //Aloitetaan musiikki uudelleen
    private void VideoStopped(VideoPlayer vp)
    {
        ResumeMusic();
    }

    //Aloitetaan musiikki uudelleen
    private void VideoPaused(VideoPlayer vp)
    {                  
       ResumeMusic();        
    }

    //Aloitetaan musiikki uudelleen
    private void ResumeMusic()
    {        
        audioSource.UnPause();        
    }  

}


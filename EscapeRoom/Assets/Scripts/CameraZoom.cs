using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 25f;
    public float minZoom = 20f;
    public float maxZoom = 60f;

    void Update()
    {
        //Saadaan skrollauksen määrä
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        ZoomCamera(scroll);
    }
    //Funktio, joka zoomaa kamera
    void ZoomCamera(float scrollValue)
    {   
        //Monikertaistetaan skrollauksen määrä ja skrollauksen nopeus
        float v = scrollValue * zoomSpeed;

        //Lisätään tämä numero kameran näkokentään 
        Camera.main.fieldOfView += v;

        //Varmistetaan, että näkökentä pysyy rajoissa 
        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minZoom, maxZoom);
    }
}
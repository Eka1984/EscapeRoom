using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCamera : MonoBehaviour
{
    // flag to keep track whether we are dragging or not
    private bool isDragging = false;

    // starting point of a camera movement
    private float startMouseX;
    private float startMouseY;

    // Camera component
    private Camera cam;

    // sensitivity for camera movement
    public float sensitivity = 1.0f;

    void Start()
    {
        // Get our camera component
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // if we press the left button and we haven't started dragging
        if (Input.GetMouseButtonDown(0) && !isDragging)
        {
            // set the flag to true
            isDragging = true;

            // save the mouse starting position
            startMouseX = Input.mousePosition.x;
            startMouseY = Input.mousePosition.y;
        }
        // if we are not pressing the left btn, and we were dragging
        else if (Input.GetMouseButtonUp(0) && isDragging)
        {
            // set the flag to false
            isDragging = false;
        }
    }

    void LateUpdate()
    {
        // Check if we are dragging and mouse is moving
        if (isDragging && (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0))
        {
            // Calculate current mouse position
            float endMouseX = Input.mousePosition.x;
            float endMouseY = Input.mousePosition.y;

            // Difference (in screen coordinates)
            float diffX = (endMouseX - startMouseX) * sensitivity;
            float diffY = (endMouseY - startMouseY) * sensitivity;

            // New center of the screen
            float newCenterX = Screen.width / 2 + diffX;
            float newCenterY = Screen.height / 2 + diffY;

            // Get the world coordinate, this is where we want to look at
            Vector3 lookHerePoint = cam.ScreenToWorldPoint(new Vector3(newCenterX, newCenterY, cam.nearClipPlane));

            // Make our camera look at the "lookHerePoint"
            transform.LookAt(lookHerePoint);

            // Starting position for the next call
            startMouseX = endMouseX;
            startMouseY = endMouseY;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    public string targetScene;

    // Kun exitobjektia klikataan, päästään seruaavalle tasolle
    private void OnMouseDown()
    {
        
        SceneManager.LoadScene(targetScene);
    }
}

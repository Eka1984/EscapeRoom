using UnityEngine;

public class PlaneSelect : MonoBehaviour
{
    public bool isHighlighted = false;
    public GameObject overlayPlane;

    //T‰ss‰ alustetaan korostusv‰ri pois p‰‰lt‰ kaikista planeista.
    void Start()
    {
        if (overlayPlane != null)
        {
            overlayPlane.SetActive(false);
        }
    }

    //T‰ss‰ katsotaan jos korostus kuvassa on jo p‰‰ll‰ niin se otetaan pois. Muuten korostus otetaan muista kuvista pois ja painettu kuva korostetaan
    void OnMouseDown()
    {
       RemoveHighlightFromOthers();
       Highlight();
    }

    void Highlight()
    {
        isHighlighted = true;

        if (overlayPlane != null)
        {
    //Korostusv‰ri laitetaan p‰‰lle
            overlayPlane.SetActive(true);
        }
    }

    void RemoveHighlight()
    {
        isHighlighted = false;

        //Korostusv‰ri otetaan pois p‰‰lt‰
        if (overlayPlane != null)
        {
            overlayPlane.SetActive(false);
        }
    }

    //Korostusv‰ri otetaan kaikilta pois p‰‰lt‰ 
    void RemoveHighlightFromOthers()
    {
        PlaneSelect[] allPictureHighlighters = FindObjectsOfType<PlaneSelect>();

        foreach (PlaneSelect pictureHighlighter in allPictureHighlighters)
        {
            if (pictureHighlighter != this && pictureHighlighter.isHighlighted)
            {
                pictureHighlighter.RemoveHighlight();
            }
        }
    }
}
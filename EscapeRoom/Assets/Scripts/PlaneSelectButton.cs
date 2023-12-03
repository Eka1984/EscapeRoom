using TMPro;
using UnityEngine;


public class PlaneSelectButton : MonoBehaviour
{
    public Renderer exitPicture;
    public Collider exitPictureCollider;
    public GameObject rightAnswer;
    public GameObject wrongAnswer;
    public Renderer button;
    public Collider buttonCollider;
    public TextMeshPro buttonText;

    private void Start()
    {
        //alustetaan scene piilottamalla exit-kuva ja piilottamalla v‰‰r‰ ja oikea ilmoitukset
        exitPicture.enabled = false;
        exitPictureCollider.enabled = false;
        rightAnswer.GetComponent<Animator>().Play("Hidden");
        wrongAnswer.GetComponent<Animator>().Play("Hidden");

    }
    void OnMouseDown()
    {
        //Tarkistetaan onko mik‰‰n plane korostettu
        PlaneSelect[] allPictureHighlighters = FindObjectsOfType<PlaneSelect>();


        foreach (PlaneSelect pictureHighlighter in allPictureHighlighters)
        {
            if (pictureHighlighter.isHighlighted)
            {
                // Tarkistetaan onko korostettu plane t‰g‰tty "correctAnswer" tagilla, jos on niin oikean vastauksen ilmoitus animaatio k‰ynnistyy,
                //ja exit-kuva ilmestyy rappusiin. Valitse nappi poistuu myˆs n‰kyvilt‰. Jos vastaus on v‰‰rin v‰‰r‰n vastauksen ilmoitus k‰ynnistyy.
                if (pictureHighlighter.gameObject.CompareTag("CorrectAnswer"))
                {
                    exitPicture.enabled = true;
                    exitPictureCollider.enabled = true;
                    button.enabled = false;
                    buttonCollider.enabled = false;
                    buttonText.enabled = false;


                    rightAnswer.GetComponent<Animator>().Play("SlideRight");
                }
                else
                {
                    wrongAnswer.GetComponent<Animator>().Play("SlideRight");
                }
            }
        }
    }
}
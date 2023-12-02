using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PickUpObjectClickHandler : MonoBehaviour
{
    //Kaksi GUI elementti‰: piste teksti ja exit -kuva
    public TextMeshProUGUI scoreText;
    public Renderer exitPicture;
    public Collider exitPictureCollider;


    //pisteet tallennetaan score -kohtaan, ja maksimim‰‰r‰ palloja kerrotaan totalSpheres -kohdassa
    private int score = 0;
    public int MaxPickUpObjects = 7; 

    private void Start()
    {
        //alustetaan scene alustamalla pisteteksti, ja piilotetaan exit -kuva
        UpdateScoreUI();
        exitPicture = GetComponent<Renderer>();
        exitPicture.enabled = false;
        exitPictureCollider.enabled = false;
    }

    void Update()
    {
        //jos painetaan hiiren vasenta n‰pp‰int‰
        if (Input.GetMouseButtonDown(0))
        {
            //l‰hetet‰‰n ray (eli s‰de) hiiren kohdalle
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //jos s‰de osuu johonkin
            if (Physics.Raycast(ray, out hit))
            {
                //jos s‰de osui asiaan, jonka tagi on "PickUpObject"
                if (hit.collider.CompareTag("PickUpObject"))
                {
                    //tuhotaan kyseinen objekti
                    Destroy(hit.collider.gameObject);
                    //, p‰ivitet‰‰n nykyisi‰ pisteit‰ ja p‰ivitet‰‰n GUI:n teksti
                    score++;
                    UpdateScoreUI();

                    //jos pisteet on suurempi tai yht‰paljon kuin objektien kokonaism‰‰r‰
                    if (score >= MaxPickUpObjects)
                    {
                        // exit -kuva tulee n‰kyviin
                        exitPicture.enabled = true;
                        exitPictureCollider.enabled = true;

                    }
                }
            }
        }
    }

    void UpdateScoreUI()
    {
        //P‰ivitet‰‰n pistem‰‰r‰ n‰ytt‰m‰‰n nykyinen tilanne
        scoreText.text = "Pisteet: " + score + "/" + MaxPickUpObjects;
    }
}
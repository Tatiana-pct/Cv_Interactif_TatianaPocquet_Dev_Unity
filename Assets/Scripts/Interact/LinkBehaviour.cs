using UnityEngine;

public class LinkBehaviour : MonoBehaviour
{
    [SerializeField] GameObject _link;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        
        switch(gameObject.tag)
        {
            case "Linkedin":
                Application.OpenURL("https://www.linkedin.com/in/tatiana-pocquet/");
                break;
            case "ENI":
                Application.OpenURL("https://www.eni.fr/?gclid=Cj0KCQiAn4SeBhCwARIsANeF9DKLUEvZzgCU6dIkQNHmp_3Ee_ORF6bX6tX0e0fbvuFhuMkmI6cG3xUaAkNhEALw_wcB");
                break;
            case "GitHub":
                Application.OpenURL("https://github.com/Tatiana-pct");
                break;
            case "Itch":
                Application.OpenURL("https://lvl-up.itch.io/");
                break;
            case "UnityPlay":
                Application.OpenURL("https://play.unity.com/u/Tatiana-Pct");
                break;
            case "3WA":
                Application.OpenURL("https://3wa.fr/formations/formation-developpeur-web/developpeur-jeux-video-unity-3d-3-mois-temps-plein/");
                break;
            case "Udemy":
                Application.OpenURL("https://www.udemy.com/");
                break;
            case "Dyma":
                Application.OpenURL("https://dyma.fr/");
                break;
            case "YouTube":
                Application.OpenURL("https://www.youtube.com/@TUTOUNITYFR");
                break;
            case "GameCodeur":
                Application.OpenURL("https://www.gamecodeur.fr/toutes-les-categories/");
                break;
            case "Email":
                Application.OpenURL("https://www.gamecodeur.fr/toutes-les-categories/");
                break;
            case "Insta":
                Application.OpenURL("https://instagram.com/tp_lvl_up?igshid=YmMyMTA2M2Y=");
                break;
        }

    }
}

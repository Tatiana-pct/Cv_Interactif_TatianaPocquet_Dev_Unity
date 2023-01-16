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
        if (gameObject.CompareTag("Linkedin"))
            {
            Application.OpenURL("https://www.linkedin.com/in/tatiana-pocquet/");
        }

        if (gameObject.CompareTag("ENI"))
        {
            Application.OpenURL("https://www.eni.fr/?gclid=Cj0KCQiAn4SeBhCwARIsANeF9DKLUEvZzgCU6dIkQNHmp_3Ee_ORF6bX6tX0e0fbvuFhuMkmI6cG3xUaAkNhEALw_wcB");
            Debug.Log("clik");
        }

    }
}

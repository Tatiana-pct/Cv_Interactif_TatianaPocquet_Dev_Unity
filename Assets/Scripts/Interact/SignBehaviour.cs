//Script servant a l'affichage des canvas des panneaux 

using TMPro;
using UnityEngine;


public class SignBehaviour : MonoBehaviour
{

    //[SerializeField] string _signText;
    //Canvas des panneaux
    [SerializeField] GameObject _canvas;
    [SerializeField] TMP_Text _text;

    //canvas d'interaction
    //[SerializeField] GameObject _canvasToucheInteract;

    private PlayerInput _playerInput;

    private void Update()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //_canvasToucheInteract.SetActive(true);


            _canvas.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Invoke("HideCanvas", 1f);

        }
    }

    public void HideCanvas()
    {
        //_canvasToucheInteract.SetActive(false);

        _canvas.SetActive(false);
    }

    public void ShowDial()
    {

    }



}

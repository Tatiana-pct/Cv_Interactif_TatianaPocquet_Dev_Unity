//Script servant a l'affichage des canvas des panneaux 

using TMPro;
using UnityEngine;


public class SignBehaviour : MonoBehaviour
{

   
    //Canvas des panneaux
    [SerializeField] GameObject _canvas;
    [SerializeField] TMP_Text _text;

    

    private PlayerInput _playerInput;

    private void Update()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            


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
       

        _canvas.SetActive(false);
    }

    



}

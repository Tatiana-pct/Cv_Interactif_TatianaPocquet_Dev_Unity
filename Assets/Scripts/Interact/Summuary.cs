using System;
using UnityEngine;

public class Summuary : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _canvas;

 


    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
          _player.transform.position = new Vector3(_canvas.transform.position.x,0f,0f);
            
        }


    }

   

}






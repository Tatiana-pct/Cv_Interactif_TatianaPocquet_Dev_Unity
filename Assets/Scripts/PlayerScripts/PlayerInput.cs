using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //Move Btn
    private float _move;

    //Interact Btn
    private bool _interact;

    public float Move { get => _move;}
    public bool Interact { get => _interact;}

    private void FixedUpdate()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
        _move = Input.GetAxisRaw("Mouse ScrollWheel");

        _interact = Input.GetKeyDown(KeyCode.Mouse0);

        //if( Input.GetAxisRaw("Mouse ScrollWheel")> 0f)
        //{
        //
        //    Debug.Log("positif");
        //    
        //}
        //else if(Input.GetAxisRaw("Mouse ScrollWheel") < 0f)
        //{
        //    Debug.Log("negatif");
        //}


    }


}

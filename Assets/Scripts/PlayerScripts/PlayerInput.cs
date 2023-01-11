using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float _move;
    

    public float Move { get => _move;}


    private void FixedUpdate()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
        _move = Input.GetAxisRaw("Mouse ScrollWheel");

        
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

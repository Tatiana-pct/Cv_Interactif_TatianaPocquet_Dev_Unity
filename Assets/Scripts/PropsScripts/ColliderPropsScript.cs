using UnityEngine;

public class ColliderPropsScript : MonoBehaviour
{
    
    [SerializeField] PlayerController _playerController;
    [SerializeField] Transform _groundPoint;
    private bool _isOnGround;
    [SerializeField] LayerMask _WhatIsTheGround;




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            _isOnGround = Physics2D.OverlapCircle(_groundPoint.position, 0.3f, _WhatIsTheGround);
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.gameObject.tag== "Player")
        {
            Debug.Log("this is the Player");
           if(_isOnGround == true)
            {
               _playerController.Jump();
                
            }
        }
    }



    
}

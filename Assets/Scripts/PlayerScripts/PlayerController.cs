using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Composant
    private Rigidbody2D _rigidbody2D;
    private PlayerInput _playerInput;
    private bool _isOnGround;
    [SerializeField] Transform _groundPoint;
    [SerializeField] LayerMask _WhatIsTheGround;

    //Moving
    [SerializeField] float _speed = 5f;
    [SerializeField] float _moveTime;
    float _moveEndTime;

    //Jumping
    Transform _targetTranform;
    Transform _transform;
    private bool _yReached;
    [SerializeField] Transform[] _JumpPointArriver;

    

    public Rigidbody2D Rigidbody2D { get => _rigidbody2D; }
    public Transform TargetTranform { get => _targetTranform; }
  

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
        _transform = transform;
    }

    // Start is called before the first frame update
    void Start()
    {

    }



    private void FixedUpdate()
    {
        Walk();

        TargetJumpPoint();



    }
    // Update is called once per frame
    void Update()
    {
        _isOnGround = Physics2D.OverlapCircle(_groundPoint.position, 0.3f, _WhatIsTheGround);
        
    }

    #region WALK
    public void Walk()
    {
        if (_playerInput.Move > 0f || _playerInput.Move < 0f)
        {
            _moveEndTime = Time.time + _moveTime;
            _rigidbody2D.velocity = new Vector2(_playerInput.Move, _rigidbody2D.velocity.y) * _speed;
        }

        //else if (Time.time > _moveEndTime)
        //{
        //    _rigidbody2D.velocity = Vector2.zero; 
        //}
    }

    #endregion

    #region JUMP

    public void Jump(int index)
    {
        _targetTranform = _JumpPointArriver[index -1];
        _rigidbody2D.gravityScale = 0;
        Debug.Log("Player Jump");


    }

    #endregion

    #region Target
    public void TargetJumpPoint()
    {
        if (_targetTranform != null)
        {
            if (Vector2.Distance(new Vector2(0f, _transform.position.y), new Vector2(0f, _targetTranform.position.y)) > 0.2f && !_yReached)
            {

                _transform.position = Vector2.MoveTowards(_transform.position, new Vector2(_transform.position.x, _targetTranform.position.y), Time.deltaTime * 8);
            }
            else if (_yReached == false)
            {
                _rigidbody2D.gravityScale = 1;
                _yReached = true;
            }

            if (_yReached)
            {
                if (Vector2.Distance(new Vector2(_transform.position.x, 0f), new Vector2(_targetTranform.position.x, 0f)) > 0.2f)
                {

                    _transform.position = Vector2.MoveTowards(_transform.position, new Vector2(_targetTranform.position.x, _transform.position.y), Time.deltaTime * 8);

                }
                else
                {
                    _targetTranform = null;
                    _yReached = false;
                }
            }


        }
    }

    #endregion


    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (_isOnGround)
        {
            switch (Other.gameObject.tag)
            {
                case "JumpPointDepart":
                    Jump(1);
                    break;
               // case "PropsColl2":
               //     Jump(2);
                 //   break;
                default:
                    break;
            }

        }
    }

}

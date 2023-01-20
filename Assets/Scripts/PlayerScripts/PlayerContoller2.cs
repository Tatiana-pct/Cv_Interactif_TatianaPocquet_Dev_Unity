using UnityEngine;

public class PlayerContoller2 : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float _scrollingTime = 0.1f;
    [SerializeField] float _scrollDistance = 0.2f;
    [SerializeField] float _scrollSpeed = 3f;
    [SerializeField] Transform[] _jumpTargetsPointsArriver;
    [SerializeField] Transform _jumpTarget;

    [SerializeField] Transform _groundPoint;
    [SerializeField] LayerMask _WhatIsTheGround;


    Rigidbody2D _rb;
    Transform _transform;
    Animator _animator;

    bool _scrollingUp;
    bool _scrollingDown;
    bool _isOnGround;
    bool _yReached;

    float _scrollingEndTime;

    public bool ScrollOver { get => Time.time > _scrollingEndTime; }


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _transform = transform;
        _animator = GetComponent<Animator>();

    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _isOnGround = Physics2D.OverlapCircle(_groundPoint.position, 0.3f, _WhatIsTheGround);

        _scrollingUp = Input.GetAxis("Mouse ScrollWheel") > 0;
        _scrollingDown = Input.GetAxis("Mouse ScrollWheel") < 0;
        if (_scrollingUp || _scrollingDown)
        {
            _scrollingEndTime = Time.time + _scrollingTime;
        }


        Walk();
        MoveChar();
        MoveJumpChar();
    }

    #region Walk
    private void Walk()
    {
        if (_target != null)
        {
            if (_scrollingUp)
            {
                _target.position -= new Vector3(_scrollDistance, 0);
               
            }
            else if (_scrollingDown)
            {
                
                _target.position += new Vector3(_scrollDistance, 0);
            }


        }
    }


    private void MoveChar()
    {
        if (Vector2.Distance(new Vector2(_transform.position.x, 0), new Vector2(_target.position.x, 0)) > 0.2f && !ScrollOver && _jumpTarget == null)
        {
            _transform.position = Vector2.MoveTowards(_transform.position, new Vector2(_target.position.x, _transform.position.y), Time.deltaTime * _scrollSpeed);

        }

        if (ScrollOver)
        {
            _target.position = new Vector2(_transform.position.x, _target.position.y);
        }
    }
    #endregion

    #region Jump
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_isOnGround)
        {
            switch (collision.gameObject.tag)
            {
                case "JumpPointDepart":
                    Jump(1);
                    break;
                case "JumpPointDepart2":
                    Jump(2);
                    break;
                case "JumpPointDepart3":
                    Jump(3);
                    break;
                case "JumpPointDepart4":
                    Jump(4);
                    break;
                case "JumpPointDepart5":
                    Jump(5);
                    break;
                default:
                    break;
            }

        }
    }

    private void Jump(int index)
    {

        _jumpTarget = _jumpTargetsPointsArriver[index - 1];
        _rb.gravityScale = 0;
        Debug.Log("Player Jump");
    }

    private void MoveJumpChar()
    {
        if (_jumpTarget != null)
        {

            if (Vector2.Distance(_transform.position, new Vector2(_transform.position.x, _jumpTarget.position.y)) > 0.2f && !_yReached)
            {
                Debug.Log("test1");
                _transform.position = Vector2.MoveTowards(new Vector2(_transform.position.x, _transform.position.y), new Vector2(_transform.position.x, _jumpTarget.position.y), Time.deltaTime * _scrollSpeed);
            }
            else if (Vector2.Distance(new Vector2(_transform.position.x, 0), new Vector2(_jumpTarget.position.x, 0)) > 0.2f)
            {
                Debug.Log("test2");
                if (!_yReached)
                {

                    _yReached = true;
                    _rb.gravityScale = 1;

                }
                _transform.position = Vector2.MoveTowards(_transform.position, new Vector2(_jumpTarget.position.x, _transform.position.y), Time.deltaTime * _scrollSpeed);
            }
            else
            {
                _rb.gravityScale = 5;
                
                _jumpTarget = null;
                _yReached = false;

            }

        }
    }

    #endregion
}

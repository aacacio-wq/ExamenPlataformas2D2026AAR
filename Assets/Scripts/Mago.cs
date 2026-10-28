using UnityEngine;
using UnityEngine.InputSystem;

public class Mago : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    private InputAction _moveAction;
    private InputAction _jumpActoin;

    private Vector2 _moveInput;
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private float _jumpSpeed = 5f;



    void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();

        _moveAction = InputSystem.actions["Move"];
    }
    
    void Start() //en verdad esto sobra pero por si acaso no lo toco
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveInput = _moveAction.ReadValue<Vector2>();

    }

    void FixedUpdate()
    {
        _rb2D.linearVelocityX = _moveInput.x * _movementSpeed;

        if (_moveInput.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (_moveInput.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

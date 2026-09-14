using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private bool isAccelerating;
    private float currentHoldTime;
    [SerializeField] private Vector2 movementForce = new Vector2(1, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnMoveRight(InputValue value)
    {
        isAccelerating = value.isPressed;
    }

    private void FixedUpdate()
    {
        if (isAccelerating) {
            rb2d.AddForce(movementForce, ForceMode2D.Force);
    }
}
    }

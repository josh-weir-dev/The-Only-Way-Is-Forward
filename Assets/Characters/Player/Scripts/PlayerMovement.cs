using UnityEditor.UI;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private bool isAccelerating;
    [SerializeField] private float currentHoldTime;
    [SerializeField] private Vector2 baseForce = new Vector2(1, 0);
    [SerializeField] private Vector2 movementForce = new Vector2(1, 0);
    [SerializeField] private float chargeRate = (float) 0.1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.y < -3f)
        {
            OnRestart();
        }
        
    }

    public void OnMoveRight(InputValue value)
    {
        isAccelerating = value.isPressed;
        currentHoldTime = 0;
        movementForce = baseForce;
    }

    public void OnRestart()
    {
        rb2d.Sleep();
        transform.position = new Vector3(0, 0, 0);
        movementForce = baseForce;
        currentHoldTime = 0;
    }

    private void FixedUpdate()
    {
        if (isAccelerating) {
            movementForce.x = baseForce.x + ((currentHoldTime * currentHoldTime) * chargeRate);
            rb2d.AddForce(movementForce, ForceMode2D.Force);
            currentHoldTime += Time.deltaTime;
    }
}
    }

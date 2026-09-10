using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb2d;
    private bool isAccelerating;
    private float currentHoldTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            isAccelerating = true;
        }
        else
        {
            isAccelerating= false;
        }
    }

    private void FixedUpdate()
    {
        if (isAccelerating) {
            rb2d.AddForce
    }
}

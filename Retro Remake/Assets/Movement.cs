using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S;
    public float speed = 40;
    public Animator animator;
    // Start is called before the first frame update

    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetKey() is for holding a key
        // Input.GetKeyDown() is for pressing a key
        // Input.GetKeyUp() is for pressing a key

        if (Input.GetKey(left)) // Checks for player holding down left
        {
            // Get the Rigidbody2D component and set its velocity to the left at the given speed
            _rb.AddForce(Vector2.left * speed);
        } 
        if (Input.GetKey(right)) // Checks for player holding down right
        {
            // Get the Rigidbody2D component and set its velocity to the right at the given speed
            _rb.AddForce(Vector2.right * speed);
        }
        if (Input.GetKey(up)) // Checks for player holding down up
        {
            // Get the Rigidbody2D component and set its velocity to the up at the given speed
            _rb.AddForce(Vector2.up * speed);
        }
        if (Input.GetKey(down)) // Checks for player holding down down
        {
            // Get the Rigidbody2D component and set its velocity to the down at the given speed
            _rb.AddForce(Vector2.down * speed);
        }
        if (Input.GetKey(KeyCode.G))
        {
            animator.SetTrigger("Hit");

        }

    }
}

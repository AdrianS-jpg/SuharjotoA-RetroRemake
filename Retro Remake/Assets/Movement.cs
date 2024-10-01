using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left = KeyCode.LeftArrow, right = KeyCode.RightArrow, up = KeyCode.UpArrow, down = KeyCode.DownArrow;
    public float speed = 70;
    public Animator animator;
    public bool planeHit = false;
    public bool dead = false;
    // Start is called before the first frame update

    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == false)
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
        }
        else
        {
            if (transform.position.x != 0 || transform.position.y != 0)
            {
                
            }
        }

        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Bomb(Clone)")
        {
            GameObject.Find("Bullet").GetComponent<firingScript>().score = GameObject.Find("Bullet").GetComponent<firingScript>().score - 50;
            animator.SetTrigger("Hit");
        }
        if (coll.gameObject.name == "Enemy Plane(Clone)")
        {
            dead = true;
            planeHit = true;
            animator.SetTrigger("Death");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode left = KeyCode.LeftArrow, right = KeyCode.RightArrow, up = KeyCode.UpArrow, down = KeyCode.DownArrow;
    public float speed = 10;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        } 
        if (Input.GetKey(right))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
        if (Input.GetKey(up))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        if (Input.GetKey(down))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
        }
    }
}

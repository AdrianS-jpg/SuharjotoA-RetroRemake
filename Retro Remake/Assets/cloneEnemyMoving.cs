using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class cloneEnemyMoving : MonoBehaviour
{
    public Animator animator;
    private Vector2 direction = Vector2.down;
    private Rigidbody2D _rb;
    public float speed = 7;
    public Transform spawnpos;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("say cheese");
        _rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();  
        spawnpos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rb.position.y == 0)
        {
           direction = Vector2.up;
        }
        _rb.velocity = direction * speed;
        Debug.Log("test");

        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("Destroyed");
            //Destroy(gameObject);
        }

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject)
        {
            animator.SetTrigger("Destroyed");
            Debug.Log("hit");
        }
    }


}



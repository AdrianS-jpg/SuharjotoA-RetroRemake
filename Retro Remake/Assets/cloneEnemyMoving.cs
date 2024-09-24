using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class cloneEnemyMoving : MonoBehaviour
{
    public Animator animator;
    private Vector2 direction = Vector2.down;
    private Rigidbody2D _rb;
    public float speed = 10;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("say cheese");
        _rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();  
        pos = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pos.position.y <= GameObject.Find("Bullet").GetComponent<enemyPlaneMovement>().depth)
        {
           direction = Vector2.up;
            Debug.Log("up");
        }
        _rb.velocity = direction * speed;

        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("Destroyed");
            //Destroy(gameObject);
        }
        if (pos.position.y >= 35)
        {
            Destroy(gameObject);
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



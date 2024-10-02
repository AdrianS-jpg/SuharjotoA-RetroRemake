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
    private float speed = 15;
    public Transform pos;
    public bool hit = false;
    public bool stop = false;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();  
        pos = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            if (hit == false)
            {
                if (pos.position.y <= GameObject.Find("Bullet").GetComponent<enemyPlaneMovement>().depth)
                {
                    direction = Vector2.up;
                }
                _rb.velocity = direction * speed;
            }
            else
            {
                _rb.velocity = Vector2.zero;
            }
            //if (Input.GetKeyDown(KeyCode.L))
            //{
            //    animator.SetTrigger("Destroyed");
            //    //Destroy(gameObject);
            //}
            if (pos.position.y >= 31)
            {
                Destroy(gameObject);
            }
            if (GameObject.Find("Plane").GetComponent<Movement>().planeHit == true)
            {
                stop = true;
                _rb.velocity = Vector2.zero;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name != "Bomb(Clone)" && coll.gameObject.name != "Enemy Plane(Clone)")
        {
            hit = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            animator.SetTrigger("Destroyed");
        }
    }
    void OnBecameInvisible()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Destroy(gameObject);
    }


}



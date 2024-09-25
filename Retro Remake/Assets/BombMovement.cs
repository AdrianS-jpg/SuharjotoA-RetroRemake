using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = Vector2.down * speed;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name != "Enemy Plane(Clone)")
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
    }
}

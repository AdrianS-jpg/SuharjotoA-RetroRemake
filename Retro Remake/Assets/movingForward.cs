using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingForward : MonoBehaviour
{
    public float speed = 50;
    public Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = Vector2.up * speed;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject)
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
    }
}


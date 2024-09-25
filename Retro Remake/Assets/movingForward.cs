using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class movingForward : MonoBehaviour
{
    public float speed = 100;
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
        if (coll.gameObject.name == "Enemy Plane(Clone)")
        {
            GameObject.Find("Bullet").GetComponent<firingScript>().score = GameObject.Find("Bullet").GetComponent<firingScript>().score + 50;
            Debug.Log(GameObject.Find("Bullet").GetComponent<firingScript>().score);
            Destroy(gameObject);
        }
        if (coll.gameObject.name == "Bomb(Clone)")
        {
            GameObject.Find("Bullet").GetComponent<firingScript>().score = GameObject.Find("Bullet").GetComponent<firingScript>().score + 25;
            Debug.Log(GameObject.Find("Bullet").GetComponent<firingScript>().score);
            Destroy(gameObject);
        }
    }
}


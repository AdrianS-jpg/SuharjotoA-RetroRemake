using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class enemyPlaneMovement : MonoBehaviour
{
    private float targetTime;
    public float speed;
    public Transform spawnpos;
    public GameObject planePrefab;
    private Rigidbody2D _rb;
    public float depth = 0;
    public int bombDrop = 1;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        targetTime = 180.0f;
}

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        Debug.Log(targetTime);

        if (targetTime <= 174.0f && targetTime >= 173.997f)
        {
            firstwave();
        }
        if (targetTime <= 160.0f && targetTime >= 159.997f)
        {
            secondwave();
        }
        //Instantiate(planePrefab, new Vector3(spawnpos.position.x, spawnpos.position.y + 3, 0), quaternion.identity);
    }
    void firstwave()
    {
        instantiate(-20, 30, 0, 0);
        instantiate(-10, 30, 0, 0);
        instantiate(0, 30, 0, 0);
        instantiate(10, 30, 0, 0);
        instantiate(20, 30, 0, 0);
        Debug.Log("it works");
    }
    void secondwave()
    {
        instantiate(-10, 30, 0, 10);
        instantiate(0, 30, 0, 10);
        instantiate(10, 30, 0, 10);
    }
    void thirdwave()
    {

    }

    void instantiate(float x, float y, float z, float d)
    {
        Instantiate(planePrefab, new Vector3(x, y, z), quaternion.identity);
        depth = d;
    }
}

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
    public float bombDrop = 0;
    public bool waveOne = false;
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
        //Debug.Log(targetTime);

        if (targetTime <= 176f && targetTime >= 175f && waveOne == false)
        {
            instantiate(-20, 30, 0, 0, 0);
            instantiate(-10, 30, 0, 0, 0);
            instantiate(0, 30, 0, 0, 0);
            waveOne = true;
        }
        if (targetTime <= 174f && targetTime >= 173f)
        {
            waveOne = false;
        }
        if (targetTime <= 172f && targetTime >= 171f && waveOne == false)
        {
            instantiate(-10, 30, 0, 10, 10);
            instantiate(0, 30, 0, 10, 10);
            instantiate(10, 30, 0, 10, 10);
            waveOne = true;
        }
        if (targetTime <= 170f && targetTime >= 169f)
        {
            waveOne = false;
        }
        if (targetTime <= 168f && targetTime >= 167f && waveOne == false)
        {
            instantiate(0, 30, 0, -5, -5);
            instantiate(10, 30, 0, -5, -5);
            instantiate(20, 30, 0, -5, -5);
            waveOne = true;
        }
        if (targetTime <= 166f && targetTime >= 165f)
        {
            waveOne = false;
        }
        if (targetTime <= 164f && targetTime >= 163f && waveOne == false)
        {
            instantiate(30, 28, 0, 2, 2);
            instantiate(40, 30, 0, 0, 0);
            waveOne = true;
        }
        if (targetTime <= 162f && targetTime >= 161f)
        {
            waveOne = false;
        }
        if (targetTime <= 160f && targetTime >= 159f && waveOne == false)
        {
            instantiate(20, 28, 0, -5, 0);
            instantiate(-10, 30, 0, -5, 0);
            instantiate(0, 29, 0, -5, 0);
            waveOne = true;
        }
        if (targetTime <= 158f && targetTime >= 157f)
        {
            waveOne = false;
        }
        if (targetTime <= 156f && targetTime >= 155f && waveOne == false)
        {
            instantiate(-30, 28, 0, -5, 0);
            instantiate(-20, 30, 0, -5, 0);
            instantiate(-25, 30, 0, -5, 0);
            waveOne = true;
        }
        if (targetTime <= 154f && targetTime >= 153f)
        {
            waveOne = false;
        }
        if (targetTime <= 153f && targetTime >= 152f && waveOne == false)
        {
            instantiate(-15, 30, 0, 0, 0);
            instantiate(-10, 28, 0, -5, 0);
            instantiate(0, 26, 0, 5, 0);
            waveOne = true;
        }
        if (targetTime <= 151f && targetTime >= 150f)
        {
            waveOne = false;
        }
        //Instantiate(planePrefab, new Vector3(spawnpos.position.x, spawnpos.position.y + 3, 0), quaternion.identity);
        if (targetTime <= 168.0f && targetTime >= 167.998f)
        {

        }
    }
    void instantiate(float x, float y, float z, float d, float b)
    {
        Instantiate(planePrefab, new Vector3(x, y, z), quaternion.identity);
        depth = d;
        bombDrop = b;

    }
}

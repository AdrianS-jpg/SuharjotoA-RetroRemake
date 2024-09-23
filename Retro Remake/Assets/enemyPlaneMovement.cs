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
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        targetTime = 10.0f;
}

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        //Debug.Log(targetTime);

        if (targetTime <= 7.0f && targetTime >= 6.998f)
        {
            firstwave();
        }
         //Instantiate(planePrefab, new Vector3(spawnpos.position.x, spawnpos.position.y + 3, 0), quaternion.identity);
    }
    void firstwave()
    {
        Instantiate(planePrefab, new Vector3(-20, 30, 0), quaternion.identity);
        Instantiate(planePrefab, new Vector3(-10, 30, 0), quaternion.identity);
        Instantiate(planePrefab, new Vector3(0, 30, 0), quaternion.identity);
        Instantiate(planePrefab, new Vector3(10, 30, 0), quaternion.identity);
        Instantiate(planePrefab, new Vector3(20, 30, 0), quaternion.identity);
        Debug.Log("it works");
    }
}

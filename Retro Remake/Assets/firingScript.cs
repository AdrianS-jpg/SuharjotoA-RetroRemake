using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class firingScript : MonoBehaviour
{
    public Transform spawnpos;
    public GameObject bulletPrefab;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, new Vector3(spawnpos.position.x,spawnpos.position.y + 3,0), quaternion.identity);
        }
    }
}

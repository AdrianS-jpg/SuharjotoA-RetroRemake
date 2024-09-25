using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.Mathematics;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class BombSpawn : MonoBehaviour
{
    public Transform pos;
    public GameObject bombGameObject;
    public bool once = false;
    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<Transform>();  
    }
    
    // Update is called once per frame
    void Update()
    {
        if (pos.position.y <= GameObject.Find("Bullet").GetComponent<enemyPlaneMovement>().depth && once == false)
        {
            Instantiate(bombGameObject, new Vector3(pos.position.x, pos.position.y - 3, 0), Quaternion.identity);
            once = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int health, score;       // Ints represent Whole Numbers
    public float speed;             // Floats represent Decimal Numbers
    public string characterName;    // Strings represent Text
    public bool isPlayerAlive;      // Bools represent True/False Values
    public Vector2 playerLocation;  // Vector2s represent X/Y position

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        
        if (isPlayerAlive)
        {
            Debug.Log("Ok cool");
        }
        else
        {
            Debug.Log("This is broken stupid fix this");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

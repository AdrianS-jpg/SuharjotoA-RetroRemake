using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeoer : MonoBehaviour
{
    public int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (number != GameObject.Find("Bullet").GetComponent<firingScript>().score)
        {
            gameObject.GetComponent<TextMeshPro>().text = "Score: " + GameObject.Find("Bullet").GetComponent<firingScript>().score;
            number = number + GameObject.Find("Bullet").GetComponent<firingScript>().score;
        }
    }
}

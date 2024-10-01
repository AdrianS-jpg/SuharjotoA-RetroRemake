using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TextMeshPro>().text = "Score: " + GameObject.Find("Bullet").GetComponent<firingScript>().score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

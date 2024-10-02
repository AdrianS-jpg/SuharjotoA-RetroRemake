using Mono.Cecil.Cil;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class enemyPlaneMovement : MonoBehaviour
{
    private float targetTime;
    public Transform spawnpos;
    public GameObject planePrefab;
    private Rigidbody2D _rb;
    public float depth = 0;
    public float bombDrop = 0;
    private bool waveOne = true;
    List<int> xValues = new List<int>();
    public int equals = 0;
    private bool notStacking = false;
    public int xTest = 0;
    private float frame = 174f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        targetTime = 180.0f;
        Debug.Log(frame);
    }

    // Update is called once per frame
    void Update()
    { 
        targetTime -= Time.deltaTime;
        Debug.Log(targetTime);
        Debug.Log(frame);
        //testing stuff for random planes
        if (GameObject.Find("Plane").GetComponent<Movement>().planeHit == false)
        {
            if (waveOne == false)
            {
                Debug.Log(waveOne);
                waveOne = true;
                Debug.Log("it works earlier");
                for (int i = 0; i < UnityEngine.Random.Range(2, 6); i++)
                {
                    notStacking = false;
                    xValues.Add(UnityEngine.Random.Range(-40, 40));
                    xTest = xValues[i];
                    check(xValues[i]);
                    while (notStacking == false)
                    {
                        xValues.RemoveAt(i);
                        xValues.Add(UnityEngine.Random.Range(-40, 40));
                        equals = 0;
                        check(xValues[i]);
                    }
                    instantiate(xValues[i], 30, 0, 0, 0);
                }
                Debug.Log(xValues.Count);
                xValues.Clear();


            }
            if (targetTime <= frame && targetTime >= frame - 1f && waveOne == true)
            {
                waveOne = false;
                frame = frame - 4f;
                Debug.Log(frame);
            }
        }
        if (targetTime <= 0)
        {
            SceneManager.LoadScene("Ending");
        }
    }
    void instantiate(float x, float y, float z, float d, float b)
    {
        Instantiate(planePrefab, new Vector3(x, y, z), quaternion.identity);
        depth = d;
        bombDrop = b;

    }
    void check(int i)
    {
        foreach (int y in xValues)
        {
            if (i == y)
            {
                
                equals++;
                if (equals == 2)
                {
                    notStacking = false;
                    Debug.Log("failed");
                    return;
                }
            }

        }
        equals = 0;
        notStacking = true;
        return;
    }
}

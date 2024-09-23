using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDeath : MonoBehaviour
{
    public float delay = 0f;

    // Use this for initialization
    void destroy()
    {
        Destroy(gameObject);
    }
}

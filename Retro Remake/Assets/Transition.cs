using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sceneSwap()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void startScene()
    {
        animator.SetBool("Start", false);
    }

    public void once()
    {
        Debug.Log("asjlkdfh");
        animator.SetBool("Once", true);
        animator.SetTrigger("Buttons");
        gameObject.GetComponent<TextMeshPro>().color = Color.white;
    }
    public void 
}

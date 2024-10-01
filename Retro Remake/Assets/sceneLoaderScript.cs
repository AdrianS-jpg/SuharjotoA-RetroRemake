using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneLoaderScript : MonoBehaviour
{
    public Animator animator;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buttontest()
    {
        SceneManager.LoadScene("Level 1");
        image.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
    }
    public void Game()
    {
        animator.SetTrigger("gameEnter");
        Debug.Log("kajsdhfl");
    }
}

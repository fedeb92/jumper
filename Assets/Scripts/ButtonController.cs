using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene("game");
    }

    public void exit()
    {
        Application.Quit();
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
    }
    public void score()
    {
        SceneManager.LoadScene("score");
    }
   

}

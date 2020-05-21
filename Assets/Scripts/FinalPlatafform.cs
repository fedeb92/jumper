using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalPlatafform : MonoBehaviour
{
    
    
    public float currentLife;
    public float currentCoins;
    void Start()
    {
        
        currentLife = GameObject.Find("GameController").GetComponent<Vida>().vida;
        currentCoins = GameObject.Find("GameController").GetComponent<Vida>().coins; 


    }

    
    void Update()
    {
      
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")&& GameObject.Find("GameController").GetComponent<Vida>().coins >= 5)
        {
            Debug.Log(currentCoins);
            PlayerPrefs.SetFloat("vida", currentLife);

            PlayerPrefs.SetFloat("moneda", GameObject.Find("GameController").GetComponent<Vida>().coins);
           
            Debug.Log(currentCoins);
            SceneManager.LoadScene("win");
            
            
        }
    }
}

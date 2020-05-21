using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag.Equals("Player"))
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);

            GameObject.Find("GameController").GetComponent<Vida>().coins = 0;
            GameObject.Find("GameController").GetComponent<Vida>().vida = GameObject.Find("GameController").GetComponent<Vida>().vida-1;
            SceneManager.LoadScene("game");

            if(GameObject.Find("GameController").GetComponent<Vida>().vida <= 0)
            {
                SceneManager.LoadScene("lose");
            }
        }
        
    }
}

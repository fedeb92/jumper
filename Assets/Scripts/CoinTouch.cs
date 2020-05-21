using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTouch : MonoBehaviour
{
    // Start is called before the first frame update
    public float cointador = 0;
    void Start()
    {

        cointador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameObject.Find("GameController").GetComponent<Vida>().coins = GameObject.Find("GameController").GetComponent<Vida>().coins +1 ;
            
            
            Destroy(gameObject);
        }
    }
}

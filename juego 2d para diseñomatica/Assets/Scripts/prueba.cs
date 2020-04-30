using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    public bool punch = false;
    public float timer = 60;
    public float kill = 30;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(timer);   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(timer -= 1);
            punch = true;
        }
        if (timer == kill)
        {
            Debug.Log(timer = 100);
            punch = false;
        }

        if(punch == true)
        {
            Debug.Log(timer -= 1);
        }
    }

    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}

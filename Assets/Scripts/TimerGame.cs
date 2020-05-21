using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerGame : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 60f;
    public Text tiempo;
    void Start()
    {
        timer -= Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        timer -= Time.deltaTime;
        if (timer <= 0)
     {
            timer = 0;

            SceneManager.LoadScene("lose");
     }
        tiempo.text = timer.ToString();
    }
}

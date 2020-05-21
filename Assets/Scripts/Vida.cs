using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    // Start is called before the first frame update
    public float vida = 3;
    public float coins = 0;
    public Text tVida;
    public Text tCoin;
    void Start()
    {
        DontDestroyOnLoad(this);
        

        
    }

    
    void Update()
    {
        SetCountText();
    }
    void SetCountText()
    {
        tVida.text = "Vida: " + vida.ToString();
        tCoin.text = "Coins:" + GameObject.Find("GameController").GetComponent<Vida>().coins.ToString();

    }
}

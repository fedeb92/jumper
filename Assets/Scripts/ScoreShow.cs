using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreShow : MonoBehaviour
{
    // Start is called before the first frame update

    public float vida;
    public float coins;
    public Text tVida;
    public Text tCoin;
    void Start()
    {
       vida = PlayerPrefs.GetFloat("vida");
        coins = PlayerPrefs.GetFloat("moneda");




    }

    // Update is called once per frame
    void Update()
    {
        SetCountText();
    }
    void SetCountText()
    {
        tVida.text = "Vida: " + vida.ToString();
        tCoin.text = "Coins:" + coins.ToString();

    }
}

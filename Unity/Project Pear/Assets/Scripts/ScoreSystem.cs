using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    private Text coinText;
    private int coin = 0;

    public int Coin
    {
        get { return coin; }
        set { coin = value; }
    }

    // Use this for initialization
    void Start()
    {
        coinText = FindObjectOfType<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (coin.ToString() != coinText.text)
        {
            coinText.text = coin.ToString();
        }
    }
}

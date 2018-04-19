using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI FinalScore;
    private Text _coinText;
    private int _coin = 0;

    public int Coin
    {
        get { return _coin; }
        set { _coin = value; }
    }

    // Use this for initialization
    void Start()
    {
        _coinText = FindObjectOfType<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_coin.ToString() != _coinText.text)
        {
            _coinText.text = _coin.ToString();
        }

        if (_coin.ToString() != FinalScore.text)
        {
            FinalScore.text = _coin.ToString();
        }
    }
}

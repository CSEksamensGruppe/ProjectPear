using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    public TextMeshProUGUI FinalScore;
    public GameObject GameUI;

    private Text _coinText;
    private int _coin;
    private float _minutes;
    private float _seconds;
    private float _milliseconds;
    private bool _takingTime;

    public int Coin
    {
        get { return _coin; }
        set { _coin = value; }
    }

    // Use this for initialization
    void Start()
    {
        _coinText = FindObjectOfType<Text>();
        _takingTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_coinText)
        {
            if (_coin.ToString() != _coinText.text)
            {
                _coinText.text = _coin.ToString();
            }
        }

        if (_coin.ToString() != FinalScore.text)
        {
            FinalScore.text = _coin.ToString();

        }

        if (Timer)
        {
            if (_takingTime)
            {
                _minutes = (int)(Time.timeSinceLevelLoad / 60f);
                _seconds = (int)(Time.timeSinceLevelLoad % 60f);
                _milliseconds = (int)(Time.timeSinceLevelLoad * 1000f) % 1000;

                if (_milliseconds > 1000f)
                {
                    _milliseconds = 0f;
                    _milliseconds = (int)(Time.timeSinceLevelLoad * 1000f) % 1000;
                }
            }
            Timer.text = _minutes.ToString("00") + ":" + _seconds.ToString("00") + ":" + _milliseconds.ToString("000");
        }
    }

    public void DestroyGameUI()
    {
        Destroy(GameUI);
    }

    public void StopTimer()
    {
        _takingTime = false;
    }

}

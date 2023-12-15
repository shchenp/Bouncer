using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GiftScoreView : MonoBehaviour
{
    [SerializeField]
    private Image _image;
    [SerializeField]
    private TextMeshProUGUI _score;

    public Color Color { get; private set; }
    public int Score { get; private set; }

    public void Initialize(Color color)
    {
        _image.color = color;
        Color = color;
        Score = 0;

        _score.text = Score.ToString();
    }

    public void SetScore(int score)
    {
        Score = score;
        _score.text = score.ToString();
    }

    public void DecreaseScore()
    {
        _score.text = (--Score).ToString();
    }
}

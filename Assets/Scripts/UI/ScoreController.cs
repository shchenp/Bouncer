using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private List<GiftScoreView> _gifts;

    public void Initialize(ColorsProvider colorsProvider)
    {
        var i = 0;
        var colors = colorsProvider.GetAllColors();
        
        foreach (var gift in _gifts)
        {
            var color = colors[i];
            gift.Initialize(color);

            i++;
        }
    }

    public void SetGiftsScores(Dictionary<Color, int> giftsScores)
    {
        foreach (var giftScore in giftsScores)
        {
            foreach (var giftScoreView in _gifts.Where(giftScoreView => giftScore.Key == giftScoreView.Color))
            {
                giftScoreView.SetScore(giftScore.Value);
                break;
            }
        }
    }

    public void UpdateScore(Color color)
    {
        foreach (var giftScoreView in _gifts)
        {
            if (giftScoreView.Color == color)
            {
                giftScoreView.DecreaseScore();
                return;
            }
        }
    }
}

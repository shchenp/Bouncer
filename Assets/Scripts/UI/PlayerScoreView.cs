using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScoreView : MonoBehaviour
{
   [SerializeField]
   private TextMeshProUGUI _score;

   public void UpdateScore(int steps)
   {
      _score.text = steps.ToString();
   }
}

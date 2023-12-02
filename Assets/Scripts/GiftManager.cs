using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftManager : MonoBehaviour
{
   [SerializeField] private Gift _giftPrefab;
   [SerializeField] private int _giftsCount = 6;

   public void Initialize(ColorsProvider colorsProvider)
   {
      for (int i = 0; i < _giftsCount; i++)
      {
         var gift = Instantiate(_giftPrefab, transform);
         var color = colorsProvider.GetColor();
         gift.Initialize(color);
      }
   }
}

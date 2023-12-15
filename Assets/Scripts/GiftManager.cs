using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GiftManager : MonoBehaviour
{
   [SerializeField]
   private Gift _giftPrefab;
   [SerializeField]
   private int _giftsCount = 6;

   [SerializeField]
   private UnityEvent<Dictionary<Color, int>> _onGiftInitialize;
   [SerializeField]
   private UnityEvent<Color> _onGiftDestroyed;

   private Dictionary<Color, int> _giftDictionary;

   public void Initialize(Player player, ColorsProvider colorsProvider)
   {
      InitializeDictionary(colorsProvider.GetAllColors());
      
      for (int i = 0; i < _giftsCount; i++)
      {
         var gift = Instantiate(_giftPrefab, transform);
         var color = colorsProvider.GetColor();
         
         gift.Initialize(player, color, _onGiftDestroyed);

         _giftDictionary[color]++;
      }
      
      _onGiftInitialize.Invoke(_giftDictionary);
   }

   public void UpdateCount(Color color)
   {
      _giftDictionary[color]--;
   }

   private void InitializeDictionary(Color[] colors)
   {
      _giftDictionary = new Dictionary<Color, int>();
      
      foreach (var color in colors)
      {
         _giftDictionary.Add(color, 0);
      }
   }
}

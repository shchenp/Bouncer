using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField]
   private GiftManager _giftManager;

   [SerializeField] private ColorsProvider _colorsProvider;

   private void Awake()
   {
      _giftManager.Initialize(_colorsProvider);
   }
}

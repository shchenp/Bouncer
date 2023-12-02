using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField]
   private GiftManager _giftManager;

   [SerializeField]
   private Candy _candy;

   [SerializeField]
   private Player _player;

   [SerializeField]
   private ColorsProvider _colorsProvider;

   private void Awake()
   {
      _player.Initialize();
      _giftManager.Initialize(_player, _colorsProvider);
      _candy.Initialize(_player, _colorsProvider);
   }
}

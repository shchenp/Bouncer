using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
   [SerializeField]
   private GiftManager _giftManager;

   [SerializeField]
   private ScoreController _scoreController;

   [SerializeField]
   private Candy _candy;

   [SerializeField]
   private Player _player;

   [SerializeField]
   private ColorsProvider _colorsProvider;

   private void Awake()
   {
      _player.Initialize();
      _scoreController.Initialize(_colorsProvider);
      _giftManager.Initialize(_player, _colorsProvider);
      _candy.Initialize(_player, _colorsProvider);
   }
}

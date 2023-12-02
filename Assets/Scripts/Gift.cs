using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class Gift : MonoBehaviour
{
    private Lid _lid;
    private Player _player;
    
    public void Initialize(Player player, Color color)
    {
        PositionProvider.SetRandomPosition(gameObject);

        _player = player;
        
        _lid = GetComponentInChildren<Lid>();
        _lid.Initialize(color);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag(GlobalConstants.PLAYER_TAG))
        {
            if (_player.GetColor() == _lid.GetColor())
            {
                Destroy(gameObject);
            }
        }
    }
}
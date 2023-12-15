using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.Events;

public class Gift : MonoBehaviour
{
    [SerializeField]
    private Lid _lid;
    
    private UnityEvent<Color> _onGiftDestroyed;
    
    private Player _player;
    
    public void Initialize(Player player, Color color, UnityEvent<Color> onGiftDestroyed)
    {
        PositionProvider.SetRandomPosition(gameObject);

        _player = player;
        _onGiftDestroyed = onGiftDestroyed;
        
        _lid.Initialize(color);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag(GlobalConstants.PLAYER_TAG))
        {
            if (_player.GetColor() == _lid.GetColor())
            {
                Destroy(gameObject);
                _onGiftDestroyed.Invoke(_lid.GetColor());
            }
        }
    }
}
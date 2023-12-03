using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class Candy : MonoBehaviour
{
    [SerializeField]
    private Renderer _renderer;

    private Player _player;
    private Material _candyMaterial;
    private ColorsProvider _colorsProvider;
    public void Initialize(Player player, ColorsProvider colorsProvider)
    {
        _player = player;
        _colorsProvider = colorsProvider;
        _candyMaterial = _renderer.material;
        SetColor(_colorsProvider);
        PositionProvider.SetRandomPosition(gameObject);
    }

    public void SetColor(ColorsProvider colorsProvider)
    {
        var color = colorsProvider.GetColor();
        _candyMaterial.color = color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GlobalConstants.PLAYER_TAG))
        {
            _player.SetColor(_candyMaterial.color);
            
            SetColor(_colorsProvider);
            PositionProvider.SetRandomPosition(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    [SerializeField]
    private Renderer _renderer;
    
    private Material _candyMaterial;
    public void Initialize(ColorsProvider colorsProvider)
    {
        _candyMaterial = _renderer.material;
        SetColor(colorsProvider);
        PositionProvider.SetPosition(gameObject);
    }

    public void SetColor(ColorsProvider colorsProvider)
    {
        var color = colorsProvider.GetColor();
        _candyMaterial.color = color;
    }
}

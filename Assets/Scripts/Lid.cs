using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lid : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private Material _ribbon;

    public void Initialize(Color color)
    {
        var materials = _renderer.materials;
        _ribbon = materials[1];
        SetColor(color);
    }

    public void SetColor(Color color)
    {
        _ribbon.color = color;
    }
}

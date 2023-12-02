using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class ColorsProvider
{
    [SerializeField]
    private Color[] _colors;

    public Color GetColor()
    {
        var index = Random.Range(0, _colors.Length);

        return _colors[index];
    }
}

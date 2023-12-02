using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class Gift : MonoBehaviour
{
    private Lid _lid;
    
    public void Initialize(Color color)
    {
        PositionProvider.SetPosition(gameObject);

        _lid = GetComponentInChildren<Lid>();
        _lid.Initialize(color);
    }
}
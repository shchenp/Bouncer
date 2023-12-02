using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    private Lid _lid;
    
    public void Initialize(PositionProvider positionProvider, Color color)
    {
        positionProvider.SetPosition(this);

        _lid = GetComponentInChildren<Lid>();
        _lid.Initialize(color);
    }
}
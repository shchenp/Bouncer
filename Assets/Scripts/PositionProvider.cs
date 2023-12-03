
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public static class PositionProvider
{
    private static int _randomRadius = 10;
    
    public static void SetRandomPosition(GameObject item)
    {
        var randomPosition = Random.insideUnitCircle * _randomRadius;
        var itemPosition = item.transform.position;

        itemPosition.x = randomPosition.x;
        itemPosition.z = randomPosition.y;

        item.transform.position = itemPosition;
    }
}
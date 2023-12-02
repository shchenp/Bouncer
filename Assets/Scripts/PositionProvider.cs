
using System;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class PositionProvider
{
    [SerializeField] 
    private int _randomRadius = 10;
    
    public void SetPosition<T>(T item) where T : MonoBehaviour
    {
        var randomPosition = Random.insideUnitCircle * _randomRadius;
        var itemPosition = item.transform.position;

        itemPosition.x = randomPosition.x;
        itemPosition.z = randomPosition.y;

        item.transform.position = itemPosition;
    }
}
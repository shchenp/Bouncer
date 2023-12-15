using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
   [SerializeField]
   private UnityEvent<int> _playerMoved;
   [SerializeField]
   private LayerMask _gameboardLayer;
   [SerializeField]
   private Rigidbody _rigidbody;
   [SerializeField]
   private Renderer _renderer;
   [SerializeField]
   private float _speed = 300;
   [SerializeField]
   private Transform _centerOfMass;
   
   private Camera _camera;
   private int _movementCount;

   public void Initialize()
   {
      _camera = Camera.main;
      _rigidbody.centerOfMass = Vector3.Scale(_centerOfMass.localPosition, transform.localScale);
   }
   private void Update()
   {
      var mousePosition = Input.mousePosition;
      
      var ray = _camera.ScreenPointToRay(mousePosition);

      if (Physics.Raycast(ray, out var hitInfo, 50f, _gameboardLayer))
      {
         if (Input.GetMouseButtonDown(0))
         {
            SetDirection(hitInfo);
         }
      }
   }

   public void SetColor(Color color)
   {
      _renderer.material.color = color;
   }

   public Color GetColor()
   {
      return _renderer.material.color;
   }

   private void SetDirection(RaycastHit hitInfo)
   {
      _rigidbody.velocity = Vector3.zero;
      var point = hitInfo.point;
      var direction = (point - transform.position).normalized;
      _rigidbody.AddForce(direction * _speed);
      
      _playerMoved.Invoke(++_movementCount);
   }
}

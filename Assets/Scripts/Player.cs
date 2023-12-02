using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField]
   private LayerMask _gameboardLayer;
   [SerializeField]
   private Rigidbody _rigidbody;
   [SerializeField]
   private Renderer _renderer;
   [SerializeField]
   private float _speed = 40;
   [SerializeField]
   private Transform _centerOfMass;
   
   private Camera _camera;

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
            var point = hitInfo.point;
            _rigidbody.AddForce(point * _speed);
         }
      }
   }

   private void OnDrawGizmos()
   {
      Gizmos.color = Color.blue;
      Gizmos.DrawSphere(_rigidbody.worldCenterOfMass, 0.1f);

   }

   public void SetColor(Color color)
   {
      _renderer.material.color = color;
   }

   public Color GetColor()
   {
      return _renderer.material.color;
   }
}

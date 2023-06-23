using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : Enemies
{

    [SerializeField] Vector3 _endPoint;
    [SerializeField] float _forwardSpeed;

    [SerializeField] GameObject _particleObject;

    private void Update()
    {
        if (Ship.Instance.state == Ship.ShipState.stop)
        {
            ParticleMove();
            EnemyMovement();
        }
        
        
    }

    public void ParticleMove()
    {
        _particleObject.transform.position = gameObject.transform.position;
    }

    public void EnemyMovement()
    {
      
       // transform.Translate(Vector3.up / _forwardSpeed*Time.deltaTime);

        transform.position = Vector3.Lerp(transform.position, _endPoint, _forwardSpeed*Time.deltaTime);
    }


}

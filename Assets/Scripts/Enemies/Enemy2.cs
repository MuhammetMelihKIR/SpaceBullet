using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemies
{

    [SerializeField] float _amplitude;
    [SerializeField] float _speed;
    float _startTime;

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
        float t = (Time.time - _startTime) * _speed;
        float xPos = Mathf.Sin(t) * _amplitude;


        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }


}

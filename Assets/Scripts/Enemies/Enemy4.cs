using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4 : Enemies
{


    [SerializeField] float _amplitude;
    [SerializeField] float _speed;
    float _startTime;
    [SerializeField] float _yPos;

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
        float t = (Time.time - _startTime)*_speed;
        float xPos = Mathf.Sin(t) * _amplitude;


        transform.Translate(new Vector3(xPos,_yPos, transform.position.z)*Time.deltaTime);


    }
}

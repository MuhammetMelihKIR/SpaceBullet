using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _ship;
    [SerializeField] Vector3 _dis;
    [SerializeField] float _speed;
    void Start()
    {
        
    }

    
    void Update()
    {if (Ship.Instance.camOn)
        transform.position = Vector3.Lerp(transform.position, _dis + _ship.position, _speed * Time.deltaTime);
    }
}

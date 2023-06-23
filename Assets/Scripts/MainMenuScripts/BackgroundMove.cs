using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Vector3 _endPoint;
    [SerializeField] Vector3 _startPoint;
   
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _endPoint, _speed * Time.deltaTime);

     
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("collider"))
        {
            transform.position = _startPoint;
        } 
    }
}

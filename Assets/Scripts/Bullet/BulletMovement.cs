using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private GameObject pivot;
    [SerializeField] private int speed;
    void Start()
    {
       

    }

    
    void Update()
    {
        transform.localEulerAngles = pivot.transform.localEulerAngles;
        Vector3 bulletVec = new Vector3(pivot.transform.position.x, 1, 0)*speed*Time.deltaTime;
        transform.Translate(bulletVec);
        
    
    }
}

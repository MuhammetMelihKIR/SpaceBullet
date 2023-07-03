using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static Bullet instance;
    Rigidbody2D rb;
    public bool bulletCollider;

    private void Awake()
    {
        instance= this;
    }
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();

        Invoke("BackToThePool", 2);

        bulletCollider = false;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void BackToThePool()
    {
        debug.log("deneme");
    
        ObjectPool.instance.pooledObjects.Enqueue(gameObject);
        gameObject.SetActive(false);
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            BackToThePool();
        }
        

       
   }
}

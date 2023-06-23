using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{

    [SerializeField]  ParticleSystem _explosion;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            
            _explosion.Play();
            gameObject.SetActive(false);
            AudioManager.instance.PlayExplosion();
            GameManager.instance.enemyCounter--;
            

        }
    }

    
}

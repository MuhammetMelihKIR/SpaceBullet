using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour
{
    public static Magazine instance;

    public List<GameObject> bullets = new List<GameObject>();
    public int bulletCounter;
    public int duration;

   



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
        }

        bulletCounter = bullets.Count;

       
    }


    public void MagazineDec()
    {
        
        bulletCounter--;
        bullets[bulletCounter].SetActive(false);

    }

   

}

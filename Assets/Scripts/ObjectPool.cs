using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    public Queue<GameObject> pooledObjects;
    [SerializeField] private GameObject _objectPrefab;
    [SerializeField] private int _poolSize;
    [SerializeField] private GameObject _spawnTransform;

    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
        }

        pooledObjects = new Queue<GameObject>();

        for (int i = 0; i < _poolSize; i++)
        {
            GameObject obj = Instantiate(_objectPrefab);

            obj.SetActive(false);
            pooledObjects.Enqueue(obj);

        }

        
    }

    
    public void GetPoolObject()
    {
        GameObject obj = pooledObjects.Dequeue();
        obj.transform.position = _spawnTransform.transform.position;
        obj.SetActive(true);

    }

   
}

using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private List<GameObject> pool = new List<GameObject>();
    
    public void AddObjectToPool(GameObject obj)
    {
        if (!pool.Contains(obj))
        {
            pool.Add(obj);
        }
    }
    
    public GameObject GetObjectFromPool()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool[0]; 
            pool.RemoveAt(0);
            return obj;
        }
        return null;
    }
    
    public bool IsObjectInPool(GameObject obj)
    {
        return pool.Contains(obj);
    }
    public bool IsPoolCreated()
    {
        return pool != null;
    }

    // Nesne sahneden silindiğinde havuza geri eklenmeli
    public void ReturnObjectToPool(GameObject obj)
    {
        if (!pool.Contains(obj))
        {
            pool.Add(obj);
        }
    }
}
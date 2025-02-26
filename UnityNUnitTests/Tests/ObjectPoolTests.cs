using NUnit.Framework;
using UnityEngine;

public class ObjectPoolTests
{
    private GameObject enemy;
    private ObjectPool objectPool;

    [SetUp]
    public void Setup()
    {
        enemy = new GameObject();
        objectPool = new GameObject().AddComponent<ObjectPool>();
    }

    [Test]
    public void EnemyReturnsToPoolWhenDestroyed()
    {
        objectPool.AddObjectToPool(enemy);
        
        GameObject.Destroy(enemy);
        
        bool isInPool = objectPool.IsObjectInPool(enemy);

        Assert.IsTrue(isInPool, "Nesne sahneden silindikten sonra havuza dönmeli");
    }

    [Test]
    public void ObjectPoolIsCreatedWhenSceneIsLoaded()
    {
        bool isPoolCreated = objectPool.IsPoolCreated();

        Assert.IsTrue(isPoolCreated, "Havuz sahne yüklendiğinde oluşturulmalı");
    }

    [Test]
    public void ObjectCanBePooledAndRetrieved()
    {
        objectPool.AddObjectToPool(enemy);
        
        GameObject pooledObject = objectPool.GetObjectFromPool();

        Assert.AreEqual(enemy, pooledObject, "Nesne havuzdan alınmalı");
    }

    [TearDown]
    public void Teardown()
    {
        GameObject.Destroy(enemy);
        GameObject.Destroy(objectPool.gameObject);
    }
}
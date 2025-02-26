using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthTest : MonoBehaviour
{
    private GameObject playerObject;
    private PlayerHealth player;

    [SetUp]
    public void Setup()
    {
        playerObject = new GameObject(); 
        player = playerObject.AddComponent<PlayerHealth>(); 
    }

    [Test]
    public void DisableOnDeath_PlayerSetInactive()
    {
        player.DisableOnDeath();

        Assert.IsFalse(player.gameObject.activeSelf); 
    }

    [Test]
    public void DisableOnDeath_PlayerRemainsActive()
    {
        player.health = 50; 
        player.DisableOnDeath();

        Assert.IsTrue(player.gameObject.activeSelf);
    }
}

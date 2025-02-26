using NUnit.Framework;
using UnityEngine;

public class EnemyAITests
{
    private GameObject enemy;
    private EnemyAI enemyAI;
    private GameObject player;

    [SetUp]
    public void Setup()
    {
        enemy = new GameObject();
        enemyAI = enemy.AddComponent<EnemyAI>();

        player = new GameObject();
        player.transform.position = new Vector3(5, 0, 0);
    }

    [Test]
    public void EnemyAttacksWhenPlayerInSight()
    {
        enemyAI.CheckForPlayer(player.transform);

        Assert.IsTrue(enemyAI.isAttacking, "Düşman, oyuncuyu görüş alanına girince saldırmalı!");
    }

    [Test]
    public void EnemyIncreasesSpeedWhenAttackingPlayer()
    {
        float initialSpeed = enemyAI.speed;


        enemyAI.CheckForPlayer(player.transform);


        float speedDuringAttack = enemyAI.speed;

        Assert.IsTrue(speedDuringAttack > initialSpeed, "Düşman saldırıya geçtiğinde hız artmalı!");
    }

    [TearDown]
    public void Teardown()
    {
        GameObject.Destroy(enemy);
        GameObject.Destroy(player);
    }
}
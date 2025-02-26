using NUnit.Framework;
using UnityEngine;

public class PlayerControllerTests
{
    private GameObject player;
    private PlayerController playerController;

    [SetUp]
    public void SetUp()
    {
        player = new GameObject();
        playerController = player.AddComponent<PlayerController>();
    }

    [Test]
    public void PlayerPositionUpdatesOnHorizontalMovement()
    {
        Vector3 initialPosition = player.transform.position;

        playerController.MovePlayer(1f, 0f); // Sağ hareket için s'm]lasyon ytapiyoruz

        Vector3 newPosition = player.transform.position;

        // poz'syon farkliligini kontroledıyor
        Assert.AreNotEqual(initialPosition, newPosition);
    }

    [Test]
    public void PlayerPositionUpdatesOnVerticalMovement()
    {
        Vector3 initialPosition = player.transform.position;

        playerController.MovePlayer(0f, 1f);

        Vector3 newPosition = player.transform.position;

        Assert.AreNotEqual(initialPosition, newPosition);
    }
}
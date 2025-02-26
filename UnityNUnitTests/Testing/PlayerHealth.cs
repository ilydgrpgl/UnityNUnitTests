using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;


    private void Update()
    {
        DisableOnDeath();
    }

    public void DisableOnDeath()
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
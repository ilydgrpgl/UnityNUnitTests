using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public bool isAttacking = false;
    public float visionRange = 10f;
    public float speed = 2f;
    public float attackSpeedMultiplier = 1.5f;

    public void CheckForPlayer(Transform player)
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= visionRange)
        {
            isAttacking = true;
            IncreaseSpeedDuringAttack();
        }
        else
        {
            isAttacking = false;
            ResetSpeed();
        }
    }


    private void IncreaseSpeedDuringAttack()
    {
        speed *= attackSpeedMultiplier;
    }


    private void ResetSpeed()
    {
        speed = 2f;
    }
}
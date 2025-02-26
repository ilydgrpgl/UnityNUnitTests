using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    public void MovePlayer(float moveX, float moveY)
    {
        Vector3 movement = new Vector3(moveX, 0, moveY) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        MovePlayer(moveX, moveY);
    }
}
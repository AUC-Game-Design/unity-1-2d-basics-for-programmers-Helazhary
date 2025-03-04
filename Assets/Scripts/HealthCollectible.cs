using UnityEngine;

public class HealthCollectible : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement controller = other.GetComponent<PlayerMovement>();


        if (controller != null && controller.health < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
        Debug.Log("Player Health: " + controller.health);

        
    }




}
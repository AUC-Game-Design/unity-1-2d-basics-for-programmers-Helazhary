using UnityEngine;

public class DamageZone : MonoBehaviour
{
    

    void OnTriggerStay2D(Collider2D other)
    {
        PlayerMovement controller = other.GetComponent<PlayerMovement>();


        if (controller != null )
        {
            controller.ChangeHealth(-1);
            
        }
        Debug.Log("Player Health: " + controller.health);

        
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{

    // public InputAction LeftAction;
    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;


    public int maxHealth = 5;
    int currentHealth;

    public int health { get { return currentHealth; } }


    //-----Invincibility Period---------------
    public float timeInvincible = 2.0f;
    bool isInvincible;
    float damageCooldown;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // LeftAction.Enable();
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;

        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10;

    }

    // Update is called once per frame
    void Update()
    {

        move = MoveAction.ReadValue<Vector2>();

        if (isInvincible)
        {
            damageCooldown -= Time.deltaTime;
            if (damageCooldown < 0)
            {
                isInvincible = false;
            }
        }
        //  Debug.Log(move);


    }

    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2d.position + move * 5.0f * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }


    public void ChangeHealth(int amount)
    {

        if (amount < 0)
        {
            if (isInvincible)
            {
                return;
            }
        }
        isInvincible = true;
        damageCooldown = timeInvincible;


        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
       UIHandler.instance.SetHealthValue(currentHealth / (float)maxHealth);

    }




}










//  USED TO BE IN VOID UPDATE
//-----
//  Vector2 position = (Vector2)transform.position + move * 5f * Time.deltaTime;
//  transform.position = position;
//---------




//         float horizontal = 0.0f;
//         float vertical = 0.0f;


//       if (LeftAction.IsPressed())
// {
//    horizontal = -1.0f;
// }



//         Vector2 position = transform.position;

//     if (Keyboard.current.leftArrowKey.isPressed)
//     {

//     horizontal = -1.0f;

//     }
//     else if (Keyboard.current.rightArrowKey.isPressed)
//     {
//         horizontal = 1.0f;
//     }
//     else if (Keyboard.current.downArrowKey.isPressed)
//     {
//         vertical = -1.0f;
//     }
//     else if (Keyboard.current.upArrowKey.isPressed)
//     {
//         vertical = 1.0f;
//     }

//  position.x = position.x + 0.1f * horizontal;
// position.y = position.y + 0.1f * vertical;
// transform.position = position;





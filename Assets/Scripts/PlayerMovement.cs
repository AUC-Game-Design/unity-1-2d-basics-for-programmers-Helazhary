using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f;
        float vertical = 0.0f;

        Vector2 position = transform.position;

        if (Keyboard.current.leftArrowKey.isPressed)
        {

        horizontal = -1.0f;

        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -1.0f;
        }
        else if (Keyboard.current.upArrowKey.isPressed)
        {
            vertical = 1.0f;
        }

     position.x = position.x + 0.1f * horizontal;
    position.y = position.y + 0.1f * vertical;
    transform.position = position;


    }
}




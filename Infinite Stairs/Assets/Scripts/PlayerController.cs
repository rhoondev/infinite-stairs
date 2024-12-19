using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int direction = -1;
    int index = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool movePlayer = false;

        if (Input.GetKeyDown(KeyCode.Space)) // CLIMB
        {
            index++;
            movePlayer = true;
        }
        else if (Input.GetKeyDown(KeyCode.A)) // TURN
        {
            direction *= -1;
            index++;
            movePlayer = true;
        }

        if (movePlayer)
        {
            transform.Translate(new Vector2(direction, 1));
        }
    }
}

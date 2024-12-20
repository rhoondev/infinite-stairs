using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] StairManager stairManager;

    int direction = -1;
    int index = 0;
    bool dead = false;

    void Update()
    {
        if (dead)
        {
            return;
        }

        bool movePlayer = false;

        if (Input.GetKeyDown(KeyCode.Space)) // CLIMB
        {
            index++;
            movePlayer = true;

            if (stairManager.HasTurn(index - 1))
            {
                StartCoroutine(Reset());
            }
        }
        else if (Input.GetKeyDown(KeyCode.A)) // TURN
        {
            direction *= -1;
            index++;
            movePlayer = true;

            if (!stairManager.HasTurn(index - 1))
            {
                StartCoroutine(Reset());
            }
        }

        if (movePlayer)
        {
            transform.Translate(new Vector2(direction, 1));
        }
    }

    IEnumerator Reset()
    {
        dead = true;

        yield return new WaitForSeconds(1f);

        direction = -1;
        index = 0;
        transform.position = Vector3.zero;
        dead = false;
    }
}

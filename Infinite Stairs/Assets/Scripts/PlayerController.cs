using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] StairManager stairManager;

    int direction;
    int index;

    void Start()
    {
        Reset();
    }

    void Update()
    {
        bool movePlayer = false;

        if (Input.GetKeyDown(KeyCode.Space)) // CLIMB
        {
            if (stairManager.HasTurn(index))
            {
                Reset();
                return;
            }

            index++;
            movePlayer = true;
        }
        else if (Input.GetKeyDown(KeyCode.A)) // TURN
        {
            if (!stairManager.HasTurn(index))
            {
                Reset();
                return;
            }

            direction *= -1;
            index++;
            movePlayer = true;
        }

        if (movePlayer)
        {
            transform.Translate(new Vector2(direction, 1));
        }
    }

    void Reset()
    {
        direction = -1;
        index = 0;
        transform.position = Vector3.zero;
    }
}

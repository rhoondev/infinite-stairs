using System.Collections.Generic;
using UnityEngine;

public class StairManager : MonoBehaviour
{
    [SerializeField] GameObject stairPrefab;

    HashSet<int> stairChanges = new HashSet<int>();

    void Start()
    {
        GenerateStairs();
    }

    public bool HasTurn(int i)
    {
        return stairChanges.Contains(i);
    }

    void GenerateStairs()
    {
        for (int i = 2; i <= 100; i++)
        {
            if (Random.value < 0.2f)
            {
                stairChanges.Add(i);
            }
        }

        int direction = -1;
        int x = -1;

        for (int i = 1; i <= 100; i++)
        {
            Vector3 stairLocation = new Vector3(x, i, 0);
            Instantiate(stairPrefab, stairLocation + Vector3.down * 0.65f, Quaternion.identity);

            if (stairChanges.Contains(i))
            {
                direction *= -1;
            }

            x += direction;
        }
    }
}
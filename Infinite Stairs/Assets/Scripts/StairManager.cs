using System.Collections.Generic;
using UnityEngine;

public class StairManager : MonoBehaviour
{
    [SerializeField] GameObject stairPrefab;
    [SerializeField] int minStretchLength;
    [SerializeField] int maxStretchLength;

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
        int index = 1;

        while (index < 100)
        {
            float rand = Mathf.Pow(Random.value, 1.5f);
            int length = (int)Mathf.Lerp(minStretchLength, maxStretchLength + 0.999f, rand);
            index += length;
            stairChanges.Add(index);
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
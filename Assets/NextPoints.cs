using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPoints : MonoBehaviour
{
    public Transform[] NextCheckPoints;
    int Chance;

    private void Awake()
    {
        StartChance();
    }
    void StartChance()
    {
        EnemyController.toPlayerChance = 100;
        Chance = EnemyController.toPlayerChance;
    }
    public Transform getNext()
    {
        // Chance = EnemyController.toPlayerChance;
        int rand = Random.Range(1, 100);
        if (rand <= Chance)
        {
            if (NextCheckPoints.Length > 1)
            {
                return NextCheckPoints[Random.Range(1, NextCheckPoints.Length)];

            }
            else
            {
                return NextCheckPoints[0];
            }
        }
        else
        {
            return NextCheckPoints[0];
        }
    }
}
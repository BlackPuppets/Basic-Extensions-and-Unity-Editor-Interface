using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;

    public int healthPoints = 10;
    public float moveSpeed = 4;
    public float movementDebuff = 2;

    public float GetTotalMovementSpeed()
    {
        if (movementDebuff <= 0)
            return moveSpeed;
        return moveSpeed / movementDebuff;
    }

    public void InstatiateEnemy()
    {
        Instantiate(enemyPrefab).transform.position = Vector3.zero;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawnValue;

    void Start()
    {

    }

    void Update()
    {
        if (Player.transform.position.y < -spawnValue)
        {
            RespawnPoint();
        }
    }

    void RespawnPoint()
    {
        transform.position = spawnPoint.position;
    }
}

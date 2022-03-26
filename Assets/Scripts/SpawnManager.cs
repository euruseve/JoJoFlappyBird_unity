using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float speed = 10f;

    private float _startDelay = 1f;
    private float _repeatRate = 2f;
    
    void Start()
    {
        InvokeRepeating("SpawnObstacles", _startDelay, _repeatRate);
    }

    void SpawnObstacles()
    {
        Vector2 spawnPosition = new Vector2(15, Random.Range(-3f, 3f));
        Instantiate(obstacle, spawnPosition, obstacle.transform.rotation);
    }

}

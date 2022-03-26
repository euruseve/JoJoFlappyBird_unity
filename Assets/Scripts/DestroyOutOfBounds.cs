using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _rightBound = 20f;
    private float _leftBound = -10f;

    void Update()
    {
        if(transform.position.x > _rightBound || transform.position.x < _leftBound)
        {
            Destroy(gameObject);
        }
    }
}

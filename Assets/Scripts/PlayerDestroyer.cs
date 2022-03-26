using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        PlayerController.instance.IsGameOver = true;
        Destroy(GameObject.FindWithTag("Player"));
    }

}

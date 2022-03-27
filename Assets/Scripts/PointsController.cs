using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsController : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;
    void Start()
    {
        pointsText.text = $"Points: {PlayerController.instance.Points}";
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        AddPoints();
    }

    void AddPoints()
    {
        PlayerController.instance.Points++;
        pointsText.text = $"Points: {PlayerController.instance.Points}";
    }


}

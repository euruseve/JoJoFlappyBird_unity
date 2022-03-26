using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsController : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;
    private int _score = 0;
    void Start()
    {
        pointsText.text = $"Points: {_score}";
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        AddPoints();
    }

    void AddPoints()
    {
        _score++;
        pointsText.text = $"Points: {_score}";
    }


}

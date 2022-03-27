using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasesController : MonoBehaviour
{
    [SerializeField] private Canvas pointsCanvas;
    [SerializeField] private Canvas restartCanvas;
    [SerializeField] private TMP_Text points;

    void Start()
    {
        
    }

    void Update()
    {
        if(PlayerController.instance.IsGameOver)
        {
            pointsCanvas.gameObject.SetActive(false);
            restartCanvas.gameObject.SetActive(true);
        }
        points.text = $"Score: {PlayerController.instance.Points}";
    }


}

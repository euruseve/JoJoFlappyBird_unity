using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    [SerializeField] private float thrust = 100f;
    
    private Rigidbody2D rb;
    private int _points = 0;
    private bool _isGameOver;

    public bool IsGameOver
    {
        get => _isGameOver;
        set
        {
            _isGameOver = value;
        }
    }

    public int Points
    {
        get => _points;
        set
        {
            _points = value;
        }
    }

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           Flying();
        }
    }

    void Flying()
    {
        rb.AddForce(Vector2.up * thrust, ForceMode2D.Impulse);
    }
}

using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;

public class PixelGuy : MonoBehaviour
{
    Vector2 destination;
    Vector2 movement;
    Rigidbody2D rb;
    Animator animator;
    public float speed = 4;
    public float health;
    public float maxHealth = 5;
    bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

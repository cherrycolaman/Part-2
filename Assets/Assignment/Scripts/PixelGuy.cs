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
    public float maxHealth = 3;
    bool killed = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = maxHealth;
    }
    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        animator.SetFloat("Movement", movement.magnitude);
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth);
        if (health == 0)
        {
            killed = true;
            animator.SetTrigger("Death");
        }
        else
        {
            killed = false;
            animator.SetTrigger("TakeDamage");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SendMessage("TakeDamage", 1);
    }
}

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
    // speed is set higher than the daggers' speed to allow player to escape them
    public float speed = 4;
    public float health;
    // max health is set to 3 (was originally 5)
    public float maxHealth = 3;
    // this boolean keeps track of whether the player has died to prevent them from moving
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
        // player moves to destination if not killed
        movement = destination - (Vector2)transform.position;
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        if (!killed)
        {
            rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
        }
        else
        {
            SendMessage("SceneTimer");
        }
        // if killed, stops movement and starts scene transition timer
    }
    // Update is called once per frame
    void Update()
    {
        // clicking triggers player movement to the mouse's location when clicked
        if (Input.GetMouseButtonDown(0))
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        // walking animation is played
        animator.SetFloat("Movement", movement.magnitude);
    }
    public void TakeDamage(float damage)
    {
        // health is reduced by amount of damage taken
        health -= damage;
        // health cannot go below 0 or higher than 3
        health = Mathf.Clamp(health, 0, maxHealth);
        // if health reaches zero, player is killed and plays death animation. Otherwise, play hurt animation
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
        // player takes damage when colliding with trigger (dagger)
        SendMessage("TakeDamage", 1);
    }
}

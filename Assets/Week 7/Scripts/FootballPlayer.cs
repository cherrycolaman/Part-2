using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballPlayer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color selectedColor;
    public Color unselectedColor;
    Rigidbody2D rb;
    public float speed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        Selected(false);
    }
    private void OnMouseDown()
    {
        Controller.SetSelectedPlayer(this);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Selected(bool isSelected)
    {
        if (isSelected)
        {
            spriteRenderer.color = selectedColor;
        }
        else
        {
            spriteRenderer.color = unselectedColor;
        }
    }
    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed);
    }
 }

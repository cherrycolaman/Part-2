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
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Selected(false);
    }
    private void OnMouseDown()
    {
        Selected(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void Selected(bool isSelected)
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
 }

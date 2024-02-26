using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Coin : MonoBehaviour
{
    Rigidbody2D rb;
    public int score;
    Vector2 coinPosition;
    public TMP_Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        score += 1;
        coinPosition.x = UnityEngine.Random.Range(-6.9f, 3.1f);
        coinPosition.y = UnityEngine.Random.Range(-3.9f, 3.9f);
        rb.MovePosition(coinPosition);
        rb.velocity = Vector2.zero;
        textScore.SetText(score.ToString());
    }
}

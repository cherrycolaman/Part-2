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
    // text is used to indicate score
    public TMP_Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // velocity is set to 0 so coin doesn't slide
        rb.velocity = Vector2.zero;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // when colliding with player, increases score and moves coin to a random location
        // coin does not collide with daggers
        score += 1;
        coinPosition.x = UnityEngine.Random.Range(-6.9f, 3.1f);
        coinPosition.y = UnityEngine.Random.Range(-3.5f, 3.5f);
        rb.MovePosition(coinPosition);
        rb.velocity = Vector2.zero;
        // text is updated to show score
        textScore.SetText(score.ToString());
    }
}

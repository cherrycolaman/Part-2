using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : MonoBehaviour
{
    float timer;
    Vector2 direction;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction.x = -3;
        direction.y = 0;
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

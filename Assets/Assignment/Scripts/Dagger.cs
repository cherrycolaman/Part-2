using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : MonoBehaviour
{
    Vector2 direction;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // daggers' direction vector is set to (-3, 0)
        direction.x = -3;
        direction.y = 0;
    }
    private void FixedUpdate()
    {
        // dagger moved at a fixed speed based on direction vector
        rb.MovePosition(rb.position + direction * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

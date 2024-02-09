using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

public class Weapon : MonoBehaviour
{
    float timer;
    Rigidbody2D rb;
    Vector2 direction;
    public GameObject knight;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        knight = GetComponent<GameObject>();
        direction.x = 1;
        direction.y = 0;
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Destroy(gameObject);
        }
    }
}

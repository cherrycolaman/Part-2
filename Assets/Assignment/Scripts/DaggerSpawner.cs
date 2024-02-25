using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerSpawner : MonoBehaviour
{
    Vector3 spawn;
    public GameObject dagger;
    float cooldown = 0.25f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        spawn = new Vector3(12, Random.Range(-5, 5), 0);
        fireDagger();
    }
    void fireDagger()
    {
        timer -= Time.deltaTime;
        if (timer > 0) return;
        timer = cooldown;
        Instantiate(dagger, spawn, Quaternion.identity);
    }
}

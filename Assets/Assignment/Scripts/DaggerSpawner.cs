using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerSpawner : MonoBehaviour
{
    Vector3 spawn;
    // dagger is called so it can be spawned
    public GameObject dagger;
    // cooldown between dagger spawn is 0.25 seconds
    float cooldown = 0.25f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // spawn is randomized somewhere on the right side of the screen and timer is checked for spawning
        spawn = new Vector3(12, Random.Range(-5f, 5f), 0);
        fireDagger();
    }
    void fireDagger()
    {
        // timer goes down until it hits 0, then it resets to 0.25 and a dagger is spawned
        timer -= Time.deltaTime;
        if (timer > 0) return;
        timer = cooldown;
        Instantiate(dagger, spawn, Quaternion.identity);
    }
}

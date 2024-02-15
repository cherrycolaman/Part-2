using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week5Loader : MonoBehaviour
{
    SceneLoader sceneloader;
    // Start is called before the first frame update
    void Start()
    {
        sceneloader = GetComponent<SceneLoader>();
        Debug.Log(sceneloader);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            sceneloader.LoadNextScene();
            Debug.Log("Right mouse click?");
        }
    }
}

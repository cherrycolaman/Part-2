using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResolutionA()
    {
        Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
    }
    public void ResolutionB()
    {
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
    }
}

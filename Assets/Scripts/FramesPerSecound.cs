using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramesPerSecound : MonoBehaviour
{
    Rect fpsRect;
    GUIStyle style;
    
    // Start is called before the first frame update
    void Start()
    {
        fpsRect = new Rect(250, 100, 400, 100);
        style = new GUIStyle();
        style.fontSize = 30;
    }

   
    void OnGUI()
    {
        float fps = 1 / Time.deltaTime;
        GUI.Label(fpsRect, "FPS: " + (int) fps, style); 

    }
}

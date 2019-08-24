using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIscript : MonoBehaviour
{
    private int playTime;
    public int endTime = 300;
    private bool endFlag = false;
    public GUIStyle textStyle;

    void Start()
    {
        
    }

    
    void Update()
    {
        playTime = endTime - (int)Time.time;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(35, 40, 100, 50), "TIME: " + playTime,textStyle);
    }


}

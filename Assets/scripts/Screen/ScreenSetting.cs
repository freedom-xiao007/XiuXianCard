using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSetting : MonoBehaviour
{

    private float screenHeight;
    private float screenWidth;

    // Start is called before the first frame update
    void Start()
    {
#if UNITY_STANDALONE_WIN
        Debug.Log("Standalone Windows");
        screenWidth = 600;
        screenHeight = 400;
        Debug.Log("screen size: " + this.screenWidth + " " + this.screenHeight);
#endif

#if UNITY_ANDROID
        Debug.Log("Standalone Android");

        screenWidth = Screen.height;
        screenHeight = Screen.width;
        Debug.Log("screen size: " + this.screenWidth + " " + this.screenHeight);
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

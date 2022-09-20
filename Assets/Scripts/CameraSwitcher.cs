using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public bool firstView;

    public Camera mainCamera;

    public Camera secondCamera;
    public KeyCode keyCode;
    
    // Start is called before the first frame update
    void Start()
    {
        secondCamera.enabled = false;
        firstView = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!firstView && Input.GetKeyDown(keyCode))
        {
            secondCamera.enabled = true;
            mainCamera.enabled = false;
            firstView = true;
            Debug.Log("Camera Switched to First view");
            return;
        }
        
        if(firstView && Input.GetKeyDown(keyCode))
        {
            secondCamera.enabled = false;
            mainCamera.enabled = true;
            firstView = false;
        }
    }
}

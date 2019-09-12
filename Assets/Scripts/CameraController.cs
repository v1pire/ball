using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Set cam size 
    private void Start()
    {
        GetComponent<Camera>().orthographicSize = (float)Screen.height / 200f;
    }
    
}

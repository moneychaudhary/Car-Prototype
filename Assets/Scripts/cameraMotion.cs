using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMotion : MonoBehaviour
	
{
    public GameObject car;
    public Vector3 offset = new Vector3(0,10,-6);
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
    	transform.position = car.transform.position + offset;
        
    }
}

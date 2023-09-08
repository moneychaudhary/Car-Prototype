using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
	
    public float speed = 20.0f;
    public float turnSpeed = 40.0f;
    public float verticalInput;
    public float horizontalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
	verticalInput = Input.GetAxis("Vertical");
	horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
	transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}

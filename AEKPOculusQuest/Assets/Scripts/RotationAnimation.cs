using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnimation : MonoBehaviour
{

    public float rotationVelocity = 0.001f;
    public float rotationDegrees;

    // Start is called before the first frame update
    void Start()
    {
        bowlRotation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bowlRotation()
    {
        rotationDegrees = 100.0f;

        transform.Rotate(new Vector3(0f, rotationDegrees, 0f) * rotationVelocity * Time.deltaTime);

    }

    
}

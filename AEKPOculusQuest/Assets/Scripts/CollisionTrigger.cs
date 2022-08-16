using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class CollisionTrigger : MonoBehaviour
{
    public GameObject spheres;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.tag == "hands"){

            spheres.GetComponent<InteractableUnityEventWrapper>().enabled = true;
        }

    }

    void OnTriggerExit(Collider other) {
        
        if (other.gameObject.tag == "hands"){

            
            spheres.GetComponent<InteractableUnityEventWrapper>().enabled = false;
            
        }

    }
}

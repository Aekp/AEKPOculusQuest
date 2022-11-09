using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerOrientation : MonoBehaviour
{
    public GameObject room;
    //[SerializeField] Transform resetTransform;
    //[SerializeField] GameObject room;
    //[SerializeField] Camera playerHead;

    Vector3 originalPos;
    public Quaternion originalRot;
    //float rotationResetSpeed = 0.1f;

    void Awake()
    {
        originalPos = room.transform.position;
        originalRot = transform.rotation;
    }
    public void Start()
    {
        OVRManager.HMDMounted += HandleHMDMounted;
        OVRManager.HMDUnmounted += HandleHMDUnMounted;


    }

    void HandleHMDMounted()
    {
        //audioObject.GetComponent<AudioSource>().Play();
    }

    void HandleHMDUnMounted()
    {
        ResetPosition();
    }

    public void ResetPosition()
    {
       
        room.transform.position = originalPos;
        room.transform.rotation = originalRot;
        
    }


}

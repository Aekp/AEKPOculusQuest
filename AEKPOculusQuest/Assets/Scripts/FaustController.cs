using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class FaustController : MonoBehaviour
{
    public  AudioClip glass;
    private AudioSource audioSource;
    public FaustPlugin_glassHarmonica scriptFaust;


    [HideInInspector]  public float bowPressure, integrationConstant;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        scriptFaust = this.GetComponent<FaustPlugin_glassHarmonica>();
        bowPressure = scriptFaust.getParameter(7);
        integrationConstant = scriptFaust.getParameter(9);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void beginAudio()
    {
        scriptFaust.setParameter(7, 0.6f);
        scriptFaust.setParameter(9, 0.2f);

        audioSource.enabled = true;
        if (!audioSource.isPlaying)
        {
            audioSource.clip = glass;
            audioSource.Play();
        }
    }

    public void stopAudio()
    {
        scriptFaust.setParameter(7, 1.0f);
        scriptFaust.setParameter(9, 0.0f);
    }
}

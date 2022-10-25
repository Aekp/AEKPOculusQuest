using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    [SerializeField]
    VideoPlayer myVideoPlayer;
    public GameObject planeMesh;

    //public Light lampLight;
    //public Light spotLight;

    // Start is called before the first frame update
    void Start()
    {
        myVideoPlayer.loopPointReached += videoFinished;
        planeMesh.GetComponent<MeshRenderer>().enabled = false;
        //lampLight = GetComponent<Light>();
        //spotLight = GetComponent<Light>();
    }


    public void videoInitiate()
    {
        myVideoPlayer.Play();
        planeMesh.GetComponent<MeshRenderer>().enabled = true;

        //lampLight.intensity = Mathf.PingPong(Time.time, 0);
        //spotLight = Mathf.PingPong(Time.time, 1);

    }

    public void videoFinished(VideoPlayer vp)
    {
        Debug.Log("Yay the video is finished");
        planeMesh.GetComponent<MeshRenderer>().enabled = false;
        //lampLight.intensity = Mathf.PingPong(Time.time, 1);
        //spotLight = Mathf.PingPong(Time.time, 0);
    }

}

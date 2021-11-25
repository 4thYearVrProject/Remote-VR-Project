using System.Collections;
using System.Collections.Generic;
//using System;
using UnityEngine;
using UnityEngine.Video;

/*

used to Control video

*/
public class VideoManager : MonoBehaviour
{

    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
      videoPlayer = GetComponent<VideoPlayer>();
    }

    void Update() {
      Debug.Log("HEYO HEYO HEYO");
    }

    public void Play() {
      videoPlayer.Play();
    }
    public void Pause() {
      videoPlayer.Pause();
    }
    public void Stop() {
      videoPlayer.Stop();
    }

    public void fileURL_Video(string url) {
      /*
      must use "/" not "\" (even if windows OS)
      */
      videoPlayer.source = VideoSource.Url;
      videoPlayer.url = url;
      videoPlayer.Prepare(); // load it!
      videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }
    public void VideoPlayer_prepareCompleted(VideoPlayer source) {
      Play();
    }
}

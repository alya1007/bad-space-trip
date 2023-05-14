using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoEndSceneLoader : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += LoadNextScene; // Subscribe to the loopPointReached event
    }

    void LoadNextScene(VideoPlayer vp)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("OldManHouse");
    }
}

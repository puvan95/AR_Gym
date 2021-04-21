using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayHandler : MonoBehaviour
{
    //Gameobject variables
    GameObject videoPanel;
    GameObject chestVidPlayer;
    GameObject pushupBtn;


    string video = "Pushup_Demo_H264.mp4";

    // Start is called before the first frame update
    void Start()
    {
        //Finding objects during runtime
        videoPanel = GameObject.Find("VideoPanel");

        //Hiding the panel
        videoPanel.SetActive(false);

        pushupBtn = GameObject.Find("Pushup_Btn");
        pushupBtn.GetComponent<Button>().onClick.AddListener(playChestVideo);
        
    }

    //Funtion: Play the video demonstration
    public void playChestVideo() {

        //Plays video in fullscreen on mobile
        Handheld.PlayFullScreenMovie(video, Color.black, FullScreenMovieControlMode.Minimal, FullScreenMovieScalingMode.AspectFit);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

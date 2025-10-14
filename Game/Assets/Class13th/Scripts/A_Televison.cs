using UnityEngine;
using UnityEngine.Video;

public class A_Televison : MonoBehaviour
{

    [SerializeField] VideoClip[] videoClips;
    [SerializeField] VideoPlayer videoPlayer;

    [SerializeField] int channel;

    private void Awake()
    {
        channel = PlayerPrefs.GetInt("Channel");

        videoPlayer.clip = videoClips[channel];
    }

    public void Increase()
    {
        channel = (channel+1) % videoClips.Length;

        videoPlayer.clip = videoClips[channel];

        PlayerPrefs.SetInt("Channel", channel);
    }

}

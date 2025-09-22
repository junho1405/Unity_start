using UnityEngine;



public class Audio_Manager : MonoBehaviour
{
    [SerializeField] static  AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public static void Emit(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
    
    public static void Create(AudioClip audioClip, Vector3 vector3)
    {
        AudioSource.PlayClipAtPoint(audioClip, vector3);
    }
}
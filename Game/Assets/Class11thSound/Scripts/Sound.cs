using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;

    void Start()
    {
        Audio_Manager.Emit(audioClip);
    }   

}

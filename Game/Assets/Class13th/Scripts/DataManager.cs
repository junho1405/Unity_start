using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] int channel;
    void Start()
    {
        PlayerPrefs.SetInt("Channel", channel);

        int x = PlayerPrefs.GetInt("Channel");

        PlayerPrefs.Save();
    }
    public void Save()
    {
        PlayerPrefs.Save();
    }

    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}

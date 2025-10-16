using UnityEngine;

public class GoTitle : MonoBehaviour
{
    [SerializeField] GameObject SceneryManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        SceneryManager = GameObject.Find("SceneryManager");
    }
    public void Return()
    {
        SceneryManager.GetComponent<SceneryManager>().LoadScene(0);
    }
}

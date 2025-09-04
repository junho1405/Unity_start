using UnityEngine;

public class item_manager : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    void Start()
    {
        for(int i = 0; i < gameObjects.Length; i++)
        {
            //Debug.Log(gameObjects[i].name);
            gameObjects[i].SetActive(false);
        }
    }
    private void Update()
    {
        
    }
}

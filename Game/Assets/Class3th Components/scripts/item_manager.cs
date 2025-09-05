using UnityEngine;

public class item_manager : MonoBehaviour
{
    [SerializeField] Item[] gameObjects;
    [SerializeField] int count;

    void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            //Debug.Log(gameObjects[i].name);
            gameObjects[i].transform.gameObject.SetActive(false);
        }
        count = gameObjects.Length - 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Swap();
        if(Input.GetMouseButtonDown(0))
        {
            gameObjects[count].Activate();
        }
    }

    void Swap()
    {
        gameObjects[count].transform.gameObject.SetActive(false);
        count = (count + 1) % gameObjects.Length;
        gameObjects[count].transform.gameObject.SetActive(true);

    }
   
}


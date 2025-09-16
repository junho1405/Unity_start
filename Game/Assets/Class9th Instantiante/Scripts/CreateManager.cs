using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class CreateManager : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] int count;
    [SerializeField] List<GameObject> unityList;
    [SerializeField] float time;

    void Start()
    {
        unityList.Capacity = 10;
        for (int i = 1; i < count; i++)
        {
            GameObject clone = Instantiate(prefab, gameObject.transform);
            clone.SetActive(false);
            unityList.Add(clone);
        }


    }

    void Update()
    {
        time += Time.deltaTime;
        if(time >=5.0f)
        {
            Debug.Log("call");
            time = 0.0f;
        }
    }
}

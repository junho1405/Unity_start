using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CreateManager : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] int index;
    [SerializeField] int count;
    [SerializeField] List<GameObject> unityList;
    [SerializeField] float time;

    void Start()
    {
        Initialize();
        StartCoroutine(Coroutine());
    }
    void Initialize()
    {
        unityList.Capacity = 10;
        for (int i = 0; i < count; i++)
        {
            GameObject clone = Instantiate(prefab, gameObject.transform);
            clone.SetActive(false);
            unityList.Add(clone);
        }
    }
    bool ExmineActive()
    {
        for(int i = 0; i<unityList.Count; i++)
        {
            if (unityList[i].activeSelf == false)
            {
                return false;
            }
        }
        return true;
    }
    IEnumerator Coroutine()
    {
        Debug.Log("Start");
        while (true)
        {
            yield return new WaitForSeconds(2.0f);  
            index = Random.Range(0, unityList.Count);
                Debug.Log(index);
            while (unityList[index].activeSelf)
            {
                index = (index+1)%unityList.Count;
            }
            unityList[index].SetActive(true);
            if(ExmineActive())
            {
                Debug.Log("³¡");
                yield break;
            }

        }
    }
}


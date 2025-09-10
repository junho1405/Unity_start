using UnityEngine;
using UnityEngine.UI;   
using System;
using UnityEngine.Rendering;
using TMPro;

public class Button_Manager : MonoBehaviour
{
    [SerializeField] Button[] buttonList;
    [SerializeField] string[] titleList = new string[3] { "Start", "Option" , "Quit" };
    private void Start()
    {
        Action[] actions = { Execute , Option , Quit};
        for (int i = 0; i < buttonList.Length; i++)
        {
            int index = i;
            buttonList[i].onClick.AddListener(() => actions[index]());
            buttonList[i].GetComponentInChildren<TextMeshProUGUI>().text = titleList[index];
        }

        //buttonList[0].onClick.AddListener(Execute);
        //buttonList[1].onClick.AddListener(Option);
        //buttonList[2].onClick.AddListener(Quit);
    }
    public void Execute()
    {
        Debug.Log("실행");
    }
    public void Option()
    {
        Debug.Log("옵션");
    }
    public void Quit()
    {
        Debug.Log("나가기");
    }
}

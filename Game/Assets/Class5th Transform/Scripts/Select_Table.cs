using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Select_Table : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;

    private void Awake()
    {
        titleText = GetComponentInChildren<TextMeshProUGUI>();
    }
    public void Enter()
    {
        titleText.fontSize = 100;
    }
    public void Exit()
    {
        titleText.fontSize = 75;

    }
    public void Down()
    {
        titleText.fontSize = 50;

    }

}

using UnityEngine;
using UnityEngine.UI;

public class Button_Manager : MonoBehaviour
{
    [SerializeField] Button[] buttonList;
    private void Start()
    {

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

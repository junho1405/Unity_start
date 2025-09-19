using UnityEngine;
using UnityEngine.Events;

public class D : MonoBehaviour
{
    [SerializeField] UnityEvent callback;

    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (callback != null)
        {
            callback.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {

    }
}

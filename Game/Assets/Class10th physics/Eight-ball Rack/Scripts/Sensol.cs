using UnityEngine;

public class Sensol : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        //other.transform.gameObject.SetActive(false);
        Debug.Log("Trigger Enter");
        //Rigidbody rb = other.attachedRigidbody;

        //if (rb != null)
        //{
        //    // 순간적으로 강하게 위로 튀어오르게
        //    rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        //    Debug.Log(other.name + " 위로 발사!");
        //}
        if (other.gameObject.tag != "Test")
        {
            Debug.Log("올바른대상이 아닙니다.");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }
}

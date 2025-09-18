using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif


public class TopDownMover3D : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidbody1;
    [SerializeField] int power;
    [SerializeField] private float launchPower = 700f; // 원하는 세기로 조절

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Sensol>() != null)  // 센서인지 확인
        {
            rigidbody1.AddForce(Vector3.up * launchPower, ForceMode.Impulse);
            Debug.Log("센서 밟음 → 위로 발사!");
        }
    }
    private void Awake()
    {
        rigidbody1 = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        
        direction.Normalize();
    }
    private void FixedUpdate()
    {
        rigidbody1.AddForce(direction*power, ForceMode.Force);
    }
}

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
    [SerializeField] int Scole;
    //[SerializeField] ForceMode forceMode;
    int point = 0;
    [SerializeField] private Vector3 startPosition;  // 시작 위치 저장용


    private void Start()
    {
        startPosition = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Reset")
        {
            // 위치를 시작 위치로 순간 이동
            transform.position = startPosition;

            // 속도 초기화
            rigidbody1.linearVelocity = Vector3.zero;
            rigidbody1.angularVelocity = Vector3.zero;

            Debug.Log("Reset 영역 충돌 → 시작 위치로 되돌림");
        }
        //

        if (other.GetComponent<Sensol>() != null)  // 센서인지 확인
        {
            rigidbody1.AddForce(Vector3.up * launchPower, ForceMode.Impulse);
            Debug.Log("센서 밟음 → 위로 발사!");
        }
        if (other.gameObject.tag == "Scole")
        {
            point += Scole;
            Debug.Log("현제 점수 : " +point+"점");
        }

    }
    private void Awake()
    {
        //forceMode = ForceMode.Force;
        //rigidbody = GetComponent<Rigidbody>();
        rigidbody1 = GetComponent<Rigidbody>();
    }
    private void soar()
    {

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

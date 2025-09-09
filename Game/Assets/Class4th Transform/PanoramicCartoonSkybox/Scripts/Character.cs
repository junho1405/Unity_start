using UnityEngine;

[RequireComponent(typeof(Move))]
public class Character : MonoBehaviour
{
    Vector3 direction;
    public float moveSpeed = 10.0f; // 이동 속도

    [SerializeField] Move move;
    //Move mover;
    //void Awake()
    //{
    //    mover = GetComponent<Move>();
    //}
    private void Awake()
    {
        move = GetComponent<Move>();
    }
    void Update()
    {
        move.OnMove(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")));
        //direction.x = Input.GetAxisRaw("Horizontal");
        //direction.z = Input.GetAxisRaw("Vertical");
        //Vector3 dir = new Vector3(direction.x, 0f, direction.z);
        //mover.OnMove(dir);
        //Debug.Log("현재 좌표: " + transform.position);

        #region 참고자료
        //float moveX = Input.GetAxis("Horizontal"); // -1(A) ~ +1(D)
        //float moveZ = Input.GetAxis("Vertical");   // -1(S) ~ +1(W)
        //
        //Vector3 direction = new Vector3(moveX, 0, moveZ);
        //
        //transform.position += direction * 0.1f; // 속도 고정값 0.1

        // Vector3  pos = transform.position;
        //if (Input.GetKeyDown(KeyCode.W)) transform.position += Vector3.forward;
        //if (Input.GetKeyDown(KeyCode.A)) transform.position += Vector3.left;
        //if (Input.GetKeyDown(KeyCode.S)) transform.position += Vector3.back;
        //if (Input.GetKeyDown(KeyCode.D)) transform.position += Vector3.right;
        // pos라는 변수에 위치값을 저장하며 이런식으로하면
        // pos.x,pos.y,pos.z라는 변수명으로 x,y,z값에 변동을 줄 수 있다.

        //Vector3 pos = transform.position;
        //
        //if (Input.GetKey(KeyCode.W))  // 앞으로 (Z+)
        //    pos.z += moveSpeed * Time.deltaTime;
        //
        //if (Input.GetKey(KeyCode.S))  // 뒤로 (Z-)
        //    pos.z -= moveSpeed * Time.deltaTime;
        //
        //if (Input.GetKey(KeyCode.A))  // 왼쪽 (X-)
        //    pos.x -= moveSpeed * Time.deltaTime;
        //
        //if (Input.GetKey(KeyCode.D))  // 오른쪽 (X+)
        //    pos.x += moveSpeed * Time.deltaTime;
        //
        //transform.position = pos;
        #endregion

    }
}

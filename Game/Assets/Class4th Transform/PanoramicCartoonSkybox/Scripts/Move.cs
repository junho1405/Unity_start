using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Move : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] Vector3 direction;

    public void OnMove(Vector3 vector3)
    {
        direction = vector3;
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;
        Debug.Log("현재 좌표: " + transform.position);
    }
    //[SerializeField] float speed = 5f;   // 초당 이동 거리
    //
    ///// <summary>입력 방향을 받아 실제 이동 처리</summary>
    //public void OnMove(Vector3 direction)
    //{
    //    // 대각선 가속 방지
    //    if (direction.sqrMagnitude > 1f) direction.Normalize();
    //
    //    // 등속 운동: P = P0 + v·t
    //    transform.position += direction * speed * Time.deltaTime;
    //}
}

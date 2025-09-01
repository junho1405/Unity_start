using UnityEngine;

public class BouncyJump : MonoBehaviour
{
    public float defaultBounceForce = 5f;
    public float highBounceForce = 15f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 충돌이 바닥 방향일 때만 반응
        if (collision.contacts[0].normal.y > 0.5f)
        {
            float g = Mathf.Abs(Physics.gravity.y);

            // 현재 낙하 속도 기반으로 추정한 낙하 높이
            float fallSpeed = Mathf.Abs(rb.linearVelocity.y);
            float fallHeight = (fallSpeed * fallSpeed) / (2 * g);

            // 도달하려는 목표 높이 = 낙하 높이의 2배
            float targetHeight = fallHeight * 2f;

            // 그 높이에 도달하기 위한 속도 계산
            float bounceVelocity = Mathf.Sqrt(2 * g * targetHeight);

            // 기본은 낮은 점프
            float finalVelocity = Mathf.Sqrt(2 * g * defaultBounceForce);

            // Plat 태그를 가진 오브젝트면 더 높이 점프
            if (collision.collider.CompareTag("Plat"))
            {
                finalVelocity = bounceVelocity;
            }

            // 수직 속도 초기화 후 점프력 적용
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);
            rb.AddForce(Vector3.up * finalVelocity, ForceMode.VelocityChange);
        }
    }
}

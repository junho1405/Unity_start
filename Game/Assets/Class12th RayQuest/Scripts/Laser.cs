using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] float maxDistance = 100f;
    [SerializeField] float damagePerClick = 10f;
    [SerializeField] LayerMask hitMask = ~0; // 기본: 전부
    [SerializeField] LayerMask layerMask;  // 피격 가능한 레이어만 선택

    Ray ray;
    RaycastHit hit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // 디버그 레이(씬 뷰에서 보임)
            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red, 0.5f);

            if (Physics.Raycast(ray, out hit, maxDistance, layerMask))
            {
                // 1) 부모에서 찾기 (콜라이더가 자식에 붙은 경우 일반적으로 부모가 적 루트)
                var hb = hit.collider.GetComponentInParent<Health_Bar>();

                // 2) 혹시 Health_Bar가 자식에 붙어있다면(현재 구조 대비) 자식에서도 한 번 더 찾기
                if (!hb) hb = hit.collider.GetComponentInChildren<Health_Bar>();

                if (hb)
                {
                    hb.TakeDamage(damagePerClick);
                }
                else
                {
                    Debug.Log(hit.collider.name + " 에 Health_Bar가 없음");
                }
            }
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] float maxHealth = 100f;
    float currentHealth;

    [Header("UI")]
    [SerializeField] Slider slider;

    void Awake()
    {
        if (!slider) slider = GetComponentInChildren<Slider>(true);

        currentHealth = maxHealth;

        if (slider)
        {
            slider.minValue = 0f;
            slider.maxValue = maxHealth;
            slider.value = currentHealth;
        }
    }

    public void TakeDamage(float amount)
    {
        if (currentHealth <= 0f) return;

        currentHealth = Mathf.Max(0f, currentHealth - amount);
        if (slider) slider.value = currentHealth;

        if (currentHealth <= 0f)
        {
            OnDie();
        }
    }

    void OnDie()
    {
        Debug.Log($"{gameObject.name} 사망");

        // Health_Bar는 Skeleton의 자식이므로
        // 부모 오브젝트(Skeleton1 전체)를 파괴
        Destroy(transform.root.gameObject);
    }
}

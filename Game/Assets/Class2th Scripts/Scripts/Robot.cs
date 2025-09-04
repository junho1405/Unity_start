using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField]  Ability ability;
    private void Awake()
    {
        //ability = new Ability();
        // Awake ��ü�� ������ �� ȣ��Ǵ� �Լ���, ��ü�� ��Ȱ��ȭ�Ǿ�
        // ���� �� ���� ȣ��Ǹ�, �� �� ���� ȣ��Ǵ� �Լ��Դϴ�.
       // ability = GetComponent<Ability>();
        Debug.Log("Awake");
        Debug.Log(ability.Strength);


    }
    private void OnEnable()
    {
        // OnEnable : ��ü�� Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnEnable"); 
    }
    void Start()
    {
        //�κ�Ŭ�������� Ability��� Ŭ������ �������Ѿ��ϰ�
        //�����ڸ� ���ؼ� �����Ǿ��ٰ� Debug.Log
        
        // Start : ��ü�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("�ҷ�����");

    }

    //private void FixedUpdate()
    //{
    //    // FixedUpdate : Time step�� ������ ���� ���� ������ ��������
    //    // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    //    Debug.Log("FixedUpdate");
    //}
    //
    //// Update is called once per frame
    //void Update()
    //{
    //    // Update : ��ü�� Ȱ��ȭ�Ǵ� ���� �� �����Ӹ��� ȣ��Ǵ� �Լ��Դϴ�.\
    //    Debug.Log("Update");
    //}
    //
    //private void LateUpdate()
    //{
    //    // LateUpdate : �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    //    Debug.Log("LageUpdate");
    //}
    private void OnDisable()
    {
        // OnDisable : ��ü�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}

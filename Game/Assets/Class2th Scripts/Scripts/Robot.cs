using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField]  Ability ability;
    private void Awake()
    {
        //ability = new Ability();
        // Awake 객체가 생성될 때 호출되는 함수로, 객체가 비활성화되어
        // 있을 때 에도 호출되며, 단 한 번만 호출되는 함수입니다.
       // ability = GetComponent<Ability>();
        Debug.Log("Awake");
        Debug.Log(ability.Strength);


    }
    private void OnEnable()
    {
        // OnEnable : 객체가 활성화 되었을 때 호출되는 이벤트 함수입니다.
        Debug.Log("OnEnable"); 
    }
    void Start()
    {
        //로봇클래스에서 Ability라는 클래스를 생성시켜야하고
        //생성자를 통해서 생성되었다고 Debug.Log
        
        // Start : 객체가 활성화되었을 때 호출되는 이벤트 함수입니다.
        Debug.Log("불러와짐");

    }

    //private void FixedUpdate()
    //{
    //    // FixedUpdate : Time step에 설정된 값에 따라 일정한 간격으로
    //    // 호출되는 이벤트 함수입니다.
    //    Debug.Log("FixedUpdate");
    //}
    //
    //// Update is called once per frame
    //void Update()
    //{
    //    // Update : 객체가 활성화되는 동안 매 프레임마다 호출되는 함수입니다.\
    //    Debug.Log("Update");
    //}
    //
    //private void LateUpdate()
    //{
    //    // LateUpdate : 한 프레임의 마지막 단계에서 호출되는 이벤트 함수입니다.
    //    Debug.Log("LageUpdate");
    //}
    private void OnDisable()
    {
        // OnDisable : 객체가 비활성화되었을 때 호출되는 이벤트 함수입니다.
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}

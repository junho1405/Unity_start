using UnityEngine;


[System.Serializable] //데이터 직렬화
public class Ability
{
    [SerializeField]private int strength = 40;

    public int Strength { get { return strength; } }
    public Ability()
    { 
        Debug.Log("Created Ability");
    }
}

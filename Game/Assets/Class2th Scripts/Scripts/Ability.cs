using UnityEngine;


[System.Serializable] //������ ����ȭ
public class Ability
{
    [SerializeField]private int strength = 40;

    public int Strength { get { return strength; } }
    public Ability()
    { 
        Debug.Log("Created Ability");
    }
}

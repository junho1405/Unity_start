using UnityEngine;

public class Smith : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] float progress;
    public void Success()
    {
        Debug.Log("성공했다.");
    }
    public void Upgrade(int count)
    {
        Debug.Log(count + "회 강화된");
    }
    public void Process(float progress)
    {
        this.progress += progress;
        Debug.Log(this.progress + "%진행");
        if (this.progress >= 100)
        {
            Success();
            this.progress = 0;
            count++;
            Upgrade(count);

        } 
        
    }
    public void Enhance(int count)
    {
        this.count += count;
        Debug.Log("강화횟수 : " + this.count);
    }
    
}

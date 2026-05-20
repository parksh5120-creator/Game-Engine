using UnityEngine;

public class Axe : MonoBehaviour
{
    public int strikes;
    public float proficiency;
    public void Attack(int count)
    {
        strikes += count;

        if (strikes % 10 == 0)
        {
            Debug.Log("Critical Hit!");
        }
    }
    public void Depend()
    {
        Debug.Log("Depend");
    }
    public void Throw(float experience)
    {

        if(proficiency < 100)
        {
            proficiency += experience;

            Debug.Log("proficiency :" + proficiency + "%");
        }
        else
        {
            Debug.Log("Mastered the Axe!");
        }
    }
}

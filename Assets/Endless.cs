using UnityEngine;

public class Endless : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject a;
    public int Number;
    public float gap=0.1f;
    public float length=5f;
    void Start()
    {
        for (int i=0;i<Number;i++){
            float zposition=i*(length+gap);
            Vector3 position=new Vector3(0,0,zposition);
            Instantiate(a,position,Quaternion.identity);
        }
    }

    
}

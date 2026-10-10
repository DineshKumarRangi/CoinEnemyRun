using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public float speed;
   public float distance;
   private Vector3 startposition;
   private int direction=1;
    void Start()
    {
        startposition=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*direction*speed*Time.deltaTime);

        if(transform.position.x>startposition.x+distance){
            direction=-1;
        }

        if(transform.position.x<startposition.x-distance){
              direction=1;
        }
    }
}

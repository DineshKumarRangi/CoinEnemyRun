using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Healthbar : MonoBehaviour
{
   public Slider a;
   public GameObject gameover;
   int life=0;
    void Start()
    {
        a.value=100;
        gameover.SetActive(false);
    }

   
    public void Damage(){
        if(a.value>0){
            a.value-=10;
        }
        if(a.value<=0){
             life++;
        

        if(life<2){
            a.value=100;
        }else{
            //Debug.Log("Game Over");
            gameover.SetActive(true);
            Time.timeScale = 0f;
        }
        }
    }

    public void heal(){
        if(a.value<100){
            a.value+=10;

        }
    }
}

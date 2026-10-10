using UnityEngine;

public class colsac : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public Healthbar ab;

   private void OnCollisionEnter(Collision a){
    if(a.gameObject.CompareTag("Enemey")){
        ab.Damage();
        transform.localScale -= new Vector3(1f, 1f, 1f);
    }

    if(a.gameObject.CompareTag("Coin")){
        ab.heal(); 
    }
   }
}

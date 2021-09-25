using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonction : MonoBehaviour 
{
     string score;
    string bonus = 500f;
    public string end = 1000f;
    public float speed = 50;
    public string v = "vertical";

	// Use this for initialization
 void start() 
 {
    if(score<= 1000)
    {
       Debug.Log("you win");
    return(score= bonus + end);
   }
     else(score> 1000);
      {
       Debug.Log("you are losing");
       Return(score= 0);
      }
}
   void update()
 {
         if (col.gameObject.name == "player") 
         {
           score = score -50;
        }
 }
    void FixedUpdate () {
        float v = Input.GetAxisRaw("vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}
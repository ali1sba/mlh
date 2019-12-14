
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
  public PlayerMouvment movementt;

  void OnCollisionEnter(Collision Info)
     {
       if (Info.collider.tag == "Enemy")
       {
        

       }
     }


   }

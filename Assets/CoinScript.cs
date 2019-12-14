using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour{

  public int points = 0 ;

    void Update()
    {
    transform.Rotate(0, 90* Time.deltaTime, 0);
    }


    private void OnTriggerEnter(Collider other)
    {

      if(other.name == "Player")
      {
        points++;
        Destroy(gameObject);
      }
    }
    private void OnGUI() {
        GUI.Label (new Rect(10,10,100,20), "Score : " + points);
        }


      }

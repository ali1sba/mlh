
using UnityEngine;

public class PlayerMouvment : MonoBehaviour
{

  public Rigidbody rb;


    void Update()
    {

        if (Input.GetKey("d"))
        {
          rb.AddForce(5,00,00);
        }
        if (Input.GetKey("q"))
        {
          rb.AddForce(-5,0,0);
        }
        if (Input.GetKey("z"))
        {
          rb.AddForce(0,0,5);
        }
        if (Input.GetKey("s"))
        {
          rb.AddForce(0,0,-5);
        }
    }}

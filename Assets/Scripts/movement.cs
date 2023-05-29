using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{   
    public Rigidbody rb;
    public float frdo=2000f;
    public float sidemv=500f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
       rb.AddForce(0,0,frdo*Time.deltaTime); 

     if (Input.GetKey("d"))
    {
        rb.AddForce(sidemv*Time.deltaTime,0,0, ForceMode.VelocityChange);
    }
    if (Input.GetKey("a"))
    {
        rb.AddForce(-sidemv*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
    if(rb.position.y<-1f)
    {
        FindObjectOfType<GameManager>().EndGame();
    }
    }
   
}

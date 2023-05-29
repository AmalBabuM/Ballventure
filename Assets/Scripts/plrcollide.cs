using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plrcollide : MonoBehaviour
{   public movement moves;
    
    void OnCollisionEnter(Collision cinfo)
    {
        if(cinfo.collider.tag=="obstacle")
        {
            moves.enabled=false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
   
}

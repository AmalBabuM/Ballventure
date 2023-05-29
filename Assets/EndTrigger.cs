using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{   public GameManager gamemanager;
   public void OnTriggerEnter()
   {
        gamemanager.CompleteLevel();
   }
}

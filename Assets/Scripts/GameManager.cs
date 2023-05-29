using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    public float RestartDelay= 1f;
    bool GameHasEnded= false;
    public GameObject CompleteLevelUI;
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void EndGame()
   {    
    if(GameHasEnded==false)
    {
        GameHasEnded=true;
        Debug.Log("Game Over");
        Invoke("Restart", RestartDelay);
    }
   }
   void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

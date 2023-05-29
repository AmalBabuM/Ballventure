using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{   
    public Transform player;
    public Rigidbody rb;
    // public Text score;
    public TextMeshProUGUI scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*scoreUI.text = rb.velocity.magnitude.ToString("0");*/
        scoreUI.text = Mathf.Clamp(player.position.z,0f, 999f).ToString("0");
        /*scoreUI.text = player.position.z.ToString("0");*/
    }
}

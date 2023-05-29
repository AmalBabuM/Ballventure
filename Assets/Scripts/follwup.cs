
using UnityEngine;

public class follwup : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform plr;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
       transform.position=plr.position + offset;
    }
}

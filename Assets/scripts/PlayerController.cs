using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float JumpInput;
    // Start is called before the first frame update
    void Start()
    {
        JumpInput = Input.GetAxis("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

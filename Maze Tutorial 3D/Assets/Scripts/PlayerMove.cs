using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input from user
        if (Input.GetKey("w")) {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey("s")) {
            transform.position -= transform.forward * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey("d")) {
            transform.position += transform.right * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey("a")) {
            transform.position -= transform.right * Time.deltaTime * moveSpeed;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, 4f)) {

        }
    }
}

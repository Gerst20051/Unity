using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public GameObject coin;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 4f)) {
            if (hit.transform.tag == "Coin") {
                Destroy(coin);
            }
        }
    }
}

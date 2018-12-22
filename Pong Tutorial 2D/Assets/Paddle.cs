using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Init(bool isRightPaddle)
    {
        Vector2 pos = Vector2.zero;

        if (isRightPaddle) {
            // Place paddle on the right of screen
            pos = new Vector2(GameManager.topRight.x, 0);
            // Move the paddle a bit to the left
            pos -= Vector2.right * transform.localScale.x;
        } else {
            // Place paddle on the left of screen
            pos = new Vector2(GameManager.bottomLeft.x, 0);
            // Move the paddle a bit to the right
            pos += Vector2.right * transform.localScale.x;
        }

        // Update the paddle's position
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

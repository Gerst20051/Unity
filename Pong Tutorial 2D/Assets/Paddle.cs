using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    float speed;
    float height;

    string input;
    bool isRight;

    // Start is called before the first frame update
    void Start()
    {
        height = transform.localScale.y;
        speed = 5f;
    }

    public void Init(bool isRightPaddle)
    {
        isRight = isRightPaddle;

        Vector2 pos = Vector2.zero;

        if (isRightPaddle) {
            // Place paddle on the right of screen
            pos = new Vector2(GameManager.topRight.x, 0);
            // Move the paddle a bit to the left
            pos -= Vector2.right * transform.localScale.x;

            input = "PaddleRight";
        } else {
            // Place paddle on the left of screen
            pos = new Vector2(GameManager.bottomLeft.x, 0);
            // Move the paddle a bit to the right
            pos += Vector2.right * transform.localScale.x;

            input = "PaddleLeft";
        }

        // Update the paddle's position
        transform.position = pos;

        transform.name = input;
    }

    // Update is called once per frame
    void Update()
    {
        // GetAxis is a number between -1 to 1 (-1 for down, 1 for up)
        float move = Input.GetAxis(input) * Time.deltaTime * speed;

        transform.Translate(move * Vector2.up);
    }
}

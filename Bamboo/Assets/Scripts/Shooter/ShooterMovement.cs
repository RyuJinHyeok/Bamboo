using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovement : MonoBehaviour
{
    private float screenWidth, screenHeight;

    void Start()
    {
        Vector3 rightTop = new Vector3(1, 1, Camera.main.transform.position.z);
        rightTop = Camera.main.ScreenToWorldPoint(rightTop);

        screenWidth = rightTop.x;
        screenHeight = rightTop.y;
    }

    private float time = 0f;

    void Update()
    {
        time += Time.deltaTime;

        float x, y;

        if (time >= 1f) {
            time = 0f;

            x = Random.Range(-1f, 1f);
            y = Random.Range(-1f, 1f);

            x += (x < 0 ? -1 : 1) * screenWidth;
            y += (y < 0 ? -1 : 1) * screenHeight;

            transform.position = new Vector2(x, y);
        }
    }
}

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
        
        StartCoroutine(GeneratePosition());
    }

    private IEnumerator GeneratePosition() {
        while (true) {

            yield return new WaitForSeconds(1.0f);

            float x, y;

            // 0: top, 1: bottom, 2: right, 3: left
            int direction = Random.Range(0, 4);

            if (direction < 2) {
                x = Random.Range(-screenWidth, screenWidth);
                y = direction == 0 ? screenHeight : -screenHeight;
            } 
            else {
                y = Random.Range(-screenHeight, screenHeight);
                x = direction == 2 ? -screenWidth : screenWidth;
            }

            transform.position = new Vector2(x, y);
        }
    }
}

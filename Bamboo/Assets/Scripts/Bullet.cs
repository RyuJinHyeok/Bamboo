using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 direction;

    public void shoot(Vector2 dir) {
        direction = dir;
        Destroy(gameObject, 15f);
    }

    // private bool isOut(Vector3 pos) {
    //     Vector3 currentPosition = Camera.main.WorldToScreenPoint(pos);        
    //     return (currentPosition.x < 0f || currentPosition.x > 1f || currentPosition.y < 0f || currentPosition.y > 1f);
    // }


    // private bool isValid = false;
    void Update()
    {
        transform.Translate(direction * 1.5f);

        // isValid = isValid || !isOut(transform.position);

        // Debug.Log(isOut(transform.position));

        // if (isValid && isOut(transform.position)) Destroy(gameObject, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 direction;

    public void shoot(Vector2 dir) {
        direction = dir;
        Destroy(gameObject, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction);
    }
}

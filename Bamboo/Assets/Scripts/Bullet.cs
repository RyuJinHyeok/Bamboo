using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 direction;

    [SerializeField]
    private float speed = 1.0f;

    public void shoot(Vector2 dir) {
        direction = dir;
    }

    private void DestroyBullet() {
        ObjectPool.ReturnObject(this);
    }

    private bool isOut() {
        Vector3 currentPosition = Camera.main.WorldToViewportPoint(transform.position);        
        return (currentPosition.x < 0f || currentPosition.x > 1f || currentPosition.y < 0f || currentPosition.y > 1f);
    }

    void Update()
    {
        transform.Translate(direction * speed);

        if (isOut()) { Invoke("DestroyBullet", 0f); }
    }
}

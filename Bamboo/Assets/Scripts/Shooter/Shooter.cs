using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private GameObject player;

    void Start() {
        StartCoroutine(ShootBullet());
    }

    IEnumerator ShootBullet() {
        while (true) {

            yield return new WaitForSeconds(1.0f);

            Vector2 direction = player.transform.position - transform.position;
            Bullet bullet = ObjectPool.GetObject();
            bullet.transform.position = transform.position;
            bullet.shoot(direction.normalized * 0.01f);
        }
    }
}

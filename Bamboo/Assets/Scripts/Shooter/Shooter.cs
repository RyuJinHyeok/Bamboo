using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private GameObject player;

    float time = 0f;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 1f) {
            time = 0f;

            Vector2 direction = player.transform.position - transform.position;
            Bullet bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity).GetComponent<Bullet>();
            bullet.shoot(direction.normalized * 0.01f);
        }
    }
}

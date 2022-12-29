using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 2.0f;

    public static bool isDead = false;

    void Awake()
    {
        transform.position = new Vector2(0, 0);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 키 입력 시 속도를 주어 오브젝트가 이동하도록 함

        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * 2, Input.GetAxisRaw("Vertical") * speed);



        // 카메라 밖으로 오브젝트가 나가지 못하도록 함

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;

        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
    
    private void OnTriggerEnter2D(Collider2D col) {
        isDead = true;
    }
}

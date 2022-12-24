using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public static float speed;

    private float x, y;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        x = -transform.position.x; 
        y = -transform.position.y;
        float theta = Mathf.Atan(x / y) * (180 / Mathf.PI);
        if (y < 0) theta += 180;
        transform.rotation = Quaternion.Euler(0, 0, -theta);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(x, y), speed * Time.deltaTime);
    }
}

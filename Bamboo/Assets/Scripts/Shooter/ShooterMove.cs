using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMove : MonoBehaviour
{
    public float timediff;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = setloc();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timediff)
        {
            transform.position = setloc();
            timer = 0;
        }
    }

    Vector2 setloc()
    {
        float x, y;
        while (true)
        {
            x = Random.Range(-11, 11);
            y = Random.Range(-6, 6);
            bool X = true ? -10 < x && x < 10 : false;
            bool Y = true ? -5.5 < y && y < 5.5 : false;

            if (X && !Y) break;
            else if (!X && Y) break;
        }

        return new Vector2(x, y);
    }
}

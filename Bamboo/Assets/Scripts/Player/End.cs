using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    [SerializeField]
    private GameObject arrow;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Arrow.speed = 0;
        ArrowShooting.keep = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetField : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.position = collision.transform.position;
    }
}

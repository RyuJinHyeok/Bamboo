using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private bool isDead = false;

    private void OnTriggerEnter2D(Collider2D col) {
        Debug.Log("충돌!");
        isDead = true;
    }

    void Update() {
        
        if (isDead) {
            Time.timeScale = 0;
        }
    }
}

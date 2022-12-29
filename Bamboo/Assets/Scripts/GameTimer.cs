using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    
    private Text text;
    private float time;

    void Awake() {
        text = GetComponent<Text>();
    }

    void Update()
    {
        time += Time.deltaTime;
        text.text = string.Format("Time : {0:D1}.{1:D2}", (int) time, (int) Mathf.Round(time * 100) % 100);
    }
}

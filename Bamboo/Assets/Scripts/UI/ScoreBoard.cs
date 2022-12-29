using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    [SerializeField] private Text TimerText;
    [SerializeField] private Text ScoreText;
    [SerializeField] private Button RestartButton;

    void Awake() {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    void Update() {
        if (canvasGroup.alpha == 1) {
            ScoreText.text = TimerText.text;
        }
    }
}

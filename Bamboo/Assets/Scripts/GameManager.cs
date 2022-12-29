using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Canvas GameUI;

    [SerializeField] private Canvas ScoreBoard;

    [SerializeField] private GameObject shooterPrefab;

    void Awake() {
        Player.isDead = false;
        Time.timeScale = 1;
        GameUI.GetComponent<CanvasGroup>().alpha = 1;
        ScoreBoard.GetComponent<CanvasGroup>().alpha = 0;
    }

    void Start() {
        StartCoroutine(AddShooter());
    }

    void Update()
    {
        if (Player.isDead) {
            Time.timeScale = 0;
            GameUI.GetComponent<CanvasGroup>().alpha = 0;
            ScoreBoard.GetComponent<CanvasGroup>().alpha = 1;
        }
    }

    public void OnClickRestart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private IEnumerator AddShooter() {
        while (!Player.isDead) {
            yield return new WaitForSeconds(10);

            Shooter shooter = Instantiate(shooterPrefab).GetComponent<Shooter>();
        }
    }
}

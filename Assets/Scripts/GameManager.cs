using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    private bool isGameOver = false;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    private float timer = 0;
    private int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (!isGameOver)
        {
            scoreText.text = $"Coin : {score} Timer : {Mathf.FloorToInt(timer)} Score : {Mathf.FloorToInt(score * 10 + timer)}";
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void EndGame()
    {
        isGameOver = true;
        gameOver.SetActive(true);
        float bestScore = PlayerPrefs.GetFloat("BestScore");
        if (bestScore < Mathf.FloorToInt(score * 10 + timer))
        {
            bestScore = Mathf.FloorToInt(score * 10 + timer);
            PlayerPrefs.SetFloat("BestScore",bestScore);
            
            //PlayerPrefs.Save();
        }
        bestScoreText.text = $"BestScore : {bestScore}";
    }
    public void AddScore()
    {
        score++;
    }
}

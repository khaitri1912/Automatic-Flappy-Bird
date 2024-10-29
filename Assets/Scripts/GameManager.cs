using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public FlappyBird bird;
    public Pipe pipes;

    public GameObject startButton;

    public Text gameOverCountdown;
    public float countTimer = 5f;


    // Start is called before the first frame update
    void Start()
    {
        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();

        gameOverCountdown.text = "Restarting in " + (countTimer).ToString("0");

        if (countTimer < 0)
        {
            RestartGame();
        }
    }

    public bool CheckCollision()
    {
        Rect birdRect = bird.GetRect();
        Rect pipeTopRect = pipes.GetTopPipeRect();
        Rect pipeDownRect = pipes.GetDownPipeRect();

        if (birdRect.Overlaps(pipeTopRect) || birdRect.Overlaps(pipeDownRect))
        {
            return true;
        }
        return false;
    }

    public void GameOver()
    {
        if (CheckCollision())
        {
            Debug.Log("Thua");
            /*gameOverCountdown.gameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;*/

            gameOverCountdown.gameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
            Time.timeScale = 0;
        }
    }

    public void StartGame()
    {
        startButton.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}

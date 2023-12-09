using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private Player player;
    private Spawner spawner;

    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public float score;
    public float coins;
    public Text coinsText;
    private bool canPowerUp = true;
    private float BirdSize = 0.5f;
    private Vector2 BaseBirdSize;



    void Update()
    {
        //PowerUp();
    }


    private void Awake()
    {
        Application.targetFrameRate = 165;

        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();



        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void GameOver()
    {
        playButton.SetActive(true);
        gameOver.SetActive(true);

        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();

        if (score % 2 == 0)
            Money();
    }

    public void Money()
    { coins = score / 2;

        coinsText.text = coins.ToString();



        }

}


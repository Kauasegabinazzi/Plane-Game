using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Director : MonoBehaviour
{
    [SerializeField]
    private GameObject imageGameOver;
    private Player player;
    private Score score;

    private void Start()
    {
        player = FindAnyObjectByType<Player>();
        score = FindAnyObjectByType<Score>();
    }

    public void FinishGame()
    {
        Time.timeScale = 0;
        imageGameOver.SetActive(true);
    }

    public void RestartGame()
    {
        imageGameOver.SetActive(false);
        Time.timeScale = 1;
        player.restart();
        DestroyAllObstacle();
        score.Restart();
    }

    private void DestroyAllObstacle()
    {
        Obstacle[] obstacles = FindObjectsByType<Obstacle>(FindObjectsSortMode.None);

        foreach (Obstacle obstacle in obstacles)
        {
            obstacle.DestroyAll();
        }
    }
}

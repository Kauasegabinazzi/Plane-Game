using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Director : MonoBehaviour
{
    private Player player;
    private Score score;
    private InterfaceGameOver gameOver;

    private void Start()
    {
        player = FindAnyObjectByType<Player>();
        score = FindAnyObjectByType<Score>();
        gameOver = FindAnyObjectByType<InterfaceGameOver>();
    }

    public void FinishGame()
    {
        Time.timeScale = 0;
        score.Save();
        gameOver.ShowInterface();
    }

    public void RestartGame()
    {
        gameOver.DisabledInterce();
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

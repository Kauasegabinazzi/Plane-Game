using UnityEngine;

public class Director : MonoBehaviour
{
    [SerializeField]
    private GameObject imageGameOver;
    private Player player;

    private void Start()
    {
        player = FindAnyObjectByType<Player>();
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

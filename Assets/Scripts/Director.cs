using UnityEngine;

public class Director : MonoBehaviour
{
    [SerializeField]
    private GameObject imageGameOver;

    public void FinishGame()
    {
        Time.timeScale = 0;
        imageGameOver.SetActive(true);
    }
}

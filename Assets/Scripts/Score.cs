using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    [SerializeField]
    private Text text;

    public void AddScore()
    {
        score++;
        text.text = score.ToString();
    }

    public void Restart()
    {
        score = 0;
        text.text = score.ToString();
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    [SerializeField]
    private Text text;
    [SerializeField]
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void AddScore()
    {
        score++;
        text.text = score.ToString();
        audioSource.Play();
    }

    public void Restart()
    {
        score = 0;
        text.text = score.ToString();
    }

    public void Save()
    {
        PlayerPrefs.SetInt("record", score);
        Debug.Log(PlayerPrefs.GetInt("record"));
    }
}

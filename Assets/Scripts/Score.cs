using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Scores { get; private set; }
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
        Scores++;
        text.text = Scores.ToString();
        audioSource.Play();
    }

    public void Restart()
    {
        Scores = 0;
        text.text = Scores.ToString();
    }

    public void Save()
    {
        int currentRecord = PlayerPrefs.GetInt("record");
        if (Scores > currentRecord)
        {
            PlayerPrefs.SetInt("record", Scores);
        }

    }
}

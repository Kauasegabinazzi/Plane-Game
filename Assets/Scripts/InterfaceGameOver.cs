using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private Text recordValue;
    [SerializeField]
    private GameObject imageGameOver;
    private Score score;
    private int record;
    [SerializeField]
    private Image medal;
    [SerializeField]
    private Sprite medalGold;
    [SerializeField]
    private Sprite medalSilver;
    [SerializeField]
    private Sprite medalBronze;

    private void Start()
    {
        score = FindAnyObjectByType<Score>();
    }
    private void UpdateInterface()
    {
        record = PlayerPrefs.GetInt("record");
        recordValue.text = record.ToString();
        this.CheckMedal();
    }

    public void ShowInterface()
    {
        UpdateInterface();
        imageGameOver.SetActive(true);
    }

    public void DisabledInterce()
    {
        imageGameOver.SetActive(false);
    }

    public void CheckMedal()
    {
        if (score.Scores > record - 2)
        {
            //ouro
            medal.sprite = medalGold;
        }
        else if (score.Scores < record / 2)
        {
            //prata
            medal.sprite = medalSilver;
        }
        else
        {
            //bronze
            medal.sprite = medalBronze;
        }

    }
}

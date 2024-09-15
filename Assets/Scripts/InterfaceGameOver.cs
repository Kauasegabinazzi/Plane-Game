using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private Text recordValue;
    [SerializeField]
    private GameObject imageGameOver;

    private void UpdateInterface()
    {
        int record = PlayerPrefs.GetInt("record");
        recordValue.text = record.ToString();
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
}

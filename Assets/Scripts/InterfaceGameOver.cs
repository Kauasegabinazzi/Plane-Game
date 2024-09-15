using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private Text recordValue;

    public void UpdateInterface()
    {
        int record = PlayerPrefs.GetInt("record");
        recordValue.text = record.ToString();
    }
}

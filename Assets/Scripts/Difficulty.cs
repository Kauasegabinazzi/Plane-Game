using UnityEngine;

public class difficulty : MonoBehaviour
{
    [SerializeField]
    private float timeForDificultyMax;
    private float timePassed;
    private float dificulty;

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        dificulty = timePassed / timeForDificultyMax;
        dificulty = Mathf.Min(1, dificulty);
        Debug.Log(dificulty);
    }
}

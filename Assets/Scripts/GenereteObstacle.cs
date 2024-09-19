using UnityEngine;
using UnityEngine.Rendering;

public class GenereteObstacle : MonoBehaviour
{
    [SerializeField]
    private float timeEasy;
    [SerializeField]
    private float timeHard;

    private float stopwatch;
    [SerializeField]
    private GameObject manual;

    private difficulty dificulty;

    private void Awake()
    {
        stopwatch = timeEasy;
    }

    private void Start()
    {
        dificulty = FindAnyObjectByType<difficulty>();
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch -= Time.deltaTime;

        if (stopwatch < 0)
        {
            GameObject.Instantiate(manual, this.transform.position, Quaternion.identity);

            stopwatch = Mathf.Lerp(timeEasy, timeHard, dificulty.dificulty);
        }
    }
}

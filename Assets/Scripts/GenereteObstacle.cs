using UnityEngine;
using UnityEngine.Rendering;

public class GenereteObstacle : MonoBehaviour
{
    [SerializeField]
    private float time;
    private float stopwatch;
    [SerializeField]
    private GameObject manual;

    private void Awake()
    {
        stopwatch = time;
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch -= Time.deltaTime;

        if (stopwatch < 0)
        {
            GameObject.Instantiate(manual, this.transform.position, Quaternion.identity);

            stopwatch = time;
        }
    }
}

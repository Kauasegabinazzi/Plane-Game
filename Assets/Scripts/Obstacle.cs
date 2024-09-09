using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.1f;
    [SerializeField]
    private float variationY;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variationY, variationY));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}

using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private SharedVariable speed;
    [SerializeField]
    private float variationY;
    private Vector3 playerPosition;
    private bool isScore;
    private Score score;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variationY, variationY));
    }

    private void Start()
    {
        playerPosition = FindAnyObjectByType<Player>().transform.position;
        score = FindAnyObjectByType<Score>();
    }

    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Vector3.left * speed.value * Time.deltaTime);

        if (!isScore && transform.position.x < playerPosition.x)
        {
            isScore = true;
            score.AddScore();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Destroy(this.gameObject);
    }

    public void DestroyAll()
    {
        Destroy(this.gameObject);
    }

}

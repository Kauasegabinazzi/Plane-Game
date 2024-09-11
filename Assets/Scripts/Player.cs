using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D physical;
    [SerializeField]
    private float force = 10;
    private Director diretor;
    private Vector3 initialPosition;

    private void Start()
    {
        diretor = GameObject.FindAnyObjectByType<Director>();
    }


    private void Awake()
    {
        this.physical = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.GetUp();
        }
    }

    private void GetUp()
    {
        this.physical.linearVelocity = Vector2.zero;
        this.physical.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        physical.simulated = false;
        diretor.FinishGame();
    }

    public void restart()
    {
        this.transform.position = initialPosition;
        this.physical.simulated = true;
    }
}

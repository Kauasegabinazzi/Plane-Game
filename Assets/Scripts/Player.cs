using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D physical;
    [SerializeField]
    private float force = 10;

    private void Awake()
    {
        this.physical = GetComponent<Rigidbody2D>();
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
}

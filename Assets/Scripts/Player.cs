using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D physical;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

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
        this.physical.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}

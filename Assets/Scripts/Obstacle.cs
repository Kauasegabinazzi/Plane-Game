using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}

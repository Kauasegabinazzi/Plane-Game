using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * 0.1f);
    }
}

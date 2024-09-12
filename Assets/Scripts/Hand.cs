using UnityEngine;

public class Hand : MonoBehaviour
{
    private SpriteRenderer image;

    private void Awake()
    {
        image = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            image.enabled = false;
        }
    }
}

using UnityEngine;
using UnityEngine.Rendering;

public class Carousel : MonoBehaviour
{
    [SerializeField]
    private SharedVariable speed;
    private Vector3 startedPositon;
    private float realSize;

    private void Awake()
    {
        //posicao inicial
        startedPositon = transform.position;
        //tamanho inicial
        float size = this.GetComponent<SpriteRenderer>().size.x;
        float scale = this.transform.localScale.x;
        this.realSize = size * scale;

    }

    // Update is called once per frame
    void Update()
    {
        float displacement = Mathf.Repeat(speed.value * Time.time, realSize);
        this.transform.position = startedPositon + Vector3.left * displacement;
    }
}

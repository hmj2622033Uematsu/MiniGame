using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] GameObject item;
    Rigidbody2D rigid2D;
    float upForce = 200.0f;
    float sideForce = 45.0f;
    int side = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        side = side * Random.Range(1, 10); 
        upForce = upForce * Random.Range(1.0f, 2.5f);
        sideForce = sideForce * Random.Range(1.0f, 2.5f);
        rigid2D = GetComponent<Rigidbody2D>();
        rigid2D.AddForce(transform.up * upForce);
        if (side > 5)
        {
            rigid2D.AddForce(transform.right * sideForce);
        }
        else
        {
            rigid2D.AddForce(Vector2.left * sideForce);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6.0f)
        {
            Destroy(item);
        }
    }
}

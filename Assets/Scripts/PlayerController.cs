using Unity.VisualScripting.InputSystem;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;



public class PlayerController : MonoBehaviour
{ 
    SpriteRenderer spriteRenderer;
    [SerializeField] GameObject manager;
    [SerializeField] AudioClip tikuwaSE;
    [SerializeField] AudioClip dumbbellSE;
    AudioSource aud;
    Rigidbody2D rigid2D;
    float sideforce = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "tikuwa")
        {
            Debug.Log("ÇøÇ≠ÇÌ");
            Destroy(collision.gameObject);
            manager.GetComponent<GameManager>().GetTikuwa();
            aud.PlayOneShot(tikuwaSE);

        }
        if(collision.gameObject.tag == "dumbbell")
        {
            Debug.Log("ìSÉAÉåÉC");
            Destroy(collision.gameObject);
            manager.GetComponent<GameManager>().GetDumbbell();
            aud.PlayOneShot(dumbbellSE);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ç∂ñÓàÛ
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            rigid2D.AddForce(Vector2.left * sideforce);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        // âEñÓàÛ
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            rigid2D.AddForce(transform.right * sideforce);
            //transform.Translate(1, 0, 0);
            GetComponent<SpriteRenderer>().flipX = true;
        }

    }
}

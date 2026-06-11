using TMPro;
using Unity.Android.Gradle;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class TimeController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float leftforce = 75f;
    float time = 0;
    int idx = 0;
    float timelimit = 11;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] sprites;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>(); 
        rigid2D.AddForce(Vector2.left *  leftforce);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   
        timelimit -= Time.deltaTime;
        time += Time.deltaTime;
        if (timelimit > 0)
        {
            if (time > 0.1f)
            {
                time = 0;
                spriteRenderer.sprite = sprites[idx];
                idx = 1 - idx; 
            }

        }
        //if (timelimit < -2)
        //{
        //    SceneManager.LoadScene("ResultScene");
        //    Debug.Log("ŽžŠÔØ‚ê");
        //}

    }
}

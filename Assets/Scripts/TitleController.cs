using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    [SerializeField] AudioClip SE;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {   
        // ÉQÅ[ÉÄÉVÅ[ÉìÇ÷
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            //GetComponent<AudioSource>().PlayOneShot(SE);
            AudioSource.PlayClipAtPoint(SE, transform.position);
            SceneManager.LoadScene("GameScene");
        }
    }
}

using System.Xml.Schema;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float time = 13.5f;
    static float toTitle = 17;
    static int score = 0;
    static int highScore = 0;
    static int minus = 0;
    int total1 = 0;
    //int total2 = 0;
    
    [SerializeField] GameObject scoreText;
    [SerializeField] GameObject minusText;
    [SerializeField] GameObject totalText;
    //[SerializeField] AudioClip resultjin;
    //AudioSource aud;
     // [SerializeField] GameObject highScoreText;
    //Start is called once before the first execution of Update after the MonoBehaviour is created

    public void GetTikuwa()
    {
        score += 100;
    }

    public void GetDumbbell()
    {
        minus -= 200;
    }

    void Start()
    {
        Application.targetFrameRate = 60; 
        //aud = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame


    void Update()
    {
        // スコアの表示
        total1 = score + minus;
        //total1 = total2;
        if(total1 >= highScore) { highScore = total1; }
        scoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
        minusText.GetComponent<TextMeshProUGUI>().text = minus.ToString();
        totalText.GetComponent<TextMeshProUGUI>().text = total1.ToString();
        //highScoreText.GetComponent<TextMeshProUGUI>().text = highScore.ToString();
        time -= Time.deltaTime;
        toTitle -= Time.deltaTime;
        // リザルト画面へ
        if (time < 0)
        {
            Debug.Log("時間切れ");
            SceneManager.LoadScene("ResultScene");
            //AudioSource.PlayClipAtPoint(resultjin, transform.position);

        }
        //タイトル画面へ
        if (toTitle < 0)
        {
            Debug.Log("タイトル");
            SceneManager.LoadScene("TitleScene");
            toTitle = 18;
            score = 0;
            minus = 0;
        }

    }
}

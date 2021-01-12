using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public static int score;
    [Header("分數1")]
    public int score1;
    [Header("分數2")]
    public int score2;
    [Header("進球音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "沙包")
        {
            AddScore();
            Destroy(GetComponent<ScoreManger>()); 
            AddScore2();
            Destroy(GetComponent<ScoreManger>());


        }
    }
    private void OnCollisionEnter(Collider other)
    {
        if(other.tag=="酒")
        {
            AddScore2();
        }
    }

    private void AddScore()
    {
        score +=score1;
        textScore.text = "得分:" + score;
        aud.PlayOneShot(soundIn,Random.Range(1.5f,3f));
    } 
    private void AddScore2()
    {
        score +=score2;
        textScore.text = "得分:" + score;
    }


}

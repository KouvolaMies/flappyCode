using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movement : MonoBehaviour
{

    private Rigidbody2D player;
    private int Scorenum;
    private int highscorenum;
    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text highscore;
    [SerializeField] private Transform pipe;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
        pipe.position = new Vector2(5, Random.Range(-4, 4));
    }

    void Update()
    {
        if(Input.GetKeyDown("space")){
            Time.timeScale = 1;
            player.velocity = new Vector2(3, 5);
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        transform.position = new Vector3(0, 0, transform.position.z);
        Time.timeScale = 0;
        Scorenum = 0;
        score.text = "score: " + Scorenum;
    }
    void OnTriggerEnter2D(Collider2D collision){
        score.text = "score: " + ++Scorenum;
        if(Scorenum > highscorenum){
            highscore.text = "highscore: " + Scorenum;
            ++highscorenum;
        }
        Invoke("pipemove", 2);
    }
    public void pipemove(){
        pipe.position = new Vector2(5, Random.Range(-4, 4));
        transform.position = new Vector3(0, transform.position.y, transform.position.z);
    }
}
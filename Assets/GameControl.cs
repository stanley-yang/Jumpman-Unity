using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public bool gameOver = false;
    public float Scrollspeed = -5f;
    public float BGScrollspeed =-0.5f;
    public Text scoreText;
    public GameObject gameOverText;

    private int score = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if(instance != this)
            Destroy (gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void playerDied()
        {
            gameOver = true;
            gameOverText.SetActive(true);
        }

    public void Score()
    {
        if(gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score;
    }
    
}

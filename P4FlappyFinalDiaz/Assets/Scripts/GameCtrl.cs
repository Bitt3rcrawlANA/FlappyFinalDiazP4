using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI

public class GameCtrl : MonoBehaviour
{
    public static GameCtrl Instance;
    public GameObject gameOverText;
    public Text scoreText;
    public bool gameOver = false;
    public float scrollSpeed = 3.5f;

    // Called before Start
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored()
    {
         if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + scoreText.ToString();
    }

    public void BirdDied()
    {
         gameOverText.SetActive(true);
         gameOver = true;
    }

}
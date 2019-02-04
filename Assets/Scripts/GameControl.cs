using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOvertext;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    void Awake()
    {
       if (instance == null) {
         instance = this;
       }
       else if (instance != this) {
         Destroy(gameObject);
       }

    }


    void Update()
    {
        //If the game is over and the player has pressed some input...
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            //...reload the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdDied()
    {
        //Activate the game over text.
        gameOvertext.SetActive (true);
        //Set the game to be over.
        gameOver = true;
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOvertext;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Awake()
    {
       //If we don't currently have a game control...
       if (instance == null)
           //...set this one to be it...
           instance = this;
       //...otherwise...
       else if(instance != this)
           //...destroy this one because it is a duplicate.
           Destroy (gameObject);
    }

    // Update is called once per frame
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

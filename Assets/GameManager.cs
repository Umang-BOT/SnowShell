using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
    int score = 0;
    public Text scoretext;
    public Text scoretextPanel;
    public GameObject gameoverpanel;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)      
        {
            instance = this;
        }
    }
    public void GameOver()
    {   
        gameOver = true;
        GameObject.Find("enemy spwan").GetComponent<enemyspawner>().stopspawning();
        scoretextPanel.text = "Score: " + score.ToString();
        gameoverpanel.SetActive(true);
    }
    public void increment()
    {
        if (!gameOver)
        {
            score += 1;
            scoretext.text = "Score: "+score.ToString();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void menu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}

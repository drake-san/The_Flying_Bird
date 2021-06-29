using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Text highScore;
    private int high;
    public GameObject scorePanel;
    public GameObject creditsPanel;
    Score score;


    public void Play()
    {
        SceneManager.LoadSceneAsync("Level");
    }

    public void HighScore()
    {
        scorePanel.SetActive(true);
        if(PlayerPrefs.HasKey("Best Score"))
        {
            int high = PlayerPrefs.GetInt("Best Score");
            highScore.text = ("High Score:" + high);
        }
        else
        {
            highScore.text = ("High Score:0");
        }
        
    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
    }

    public void ExitCredits()
    {
        creditsPanel.SetActive(false);
    }

    public void ExitHighScore()
    {
        scorePanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

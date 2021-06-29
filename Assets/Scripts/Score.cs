using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text label;

    private void OnGUI()
    {
        label.text = ("Score:" + score.ToString());
    }

    public void Save()
    {
        if(score>=PlayerPrefs.GetInt("Best Score"))
        {
            PlayerPrefs.SetInt("Best Score", score);
        }    
        
    }


}

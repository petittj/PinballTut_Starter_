using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public static string PlayerName; // STATIC so it is preserved between classes
    public InputField PlayerNameInput;
    public Text showPlayerName;
    //public int theScore = ScoreBoard.Score;
    public Text showScore;
    public static int BallNum;
    public Dropdown MyDropDown;

    public Text ShowNumOfBall;

    public Text HighScore;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }

    public void UpdateName() //executed in each letter change
    {
        PlayerName = PlayerNameInput.text; // assign new input text to string
        Debug.Log(PlayerName); //prints updated name to log on each letter change
        showPlayerName.text = PlayerName; // show string in the textbox just to see that it works in the Intro scene. 
    }
    public void ShowName()
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }

    public void ShowScore()
    { 
        showScore.text = DestroyBall.theScore.ToString();
        Debug.Log(DestroyBall.theScore);
    }

    public void ShowHighScore()
    {
        HighScore.text = DestroyBall.HighScore.ToString();
        Debug.Log(DestroyBall.HighScore);
    }



    public void BallChoice()
    {
        switch (MyDropDown.value)
        {
            case 1:
                BallNum = 1;
                break;
            case 2:
                BallNum = 2;
                break;
            case 3:
                BallNum = 3;
                break;
            default:
                BallNum = 1;
                break;
        }
        DestroyBall.count = 0;
    }
    
    public void ShowBallNum()
    {
        ShowNumOfBall.text = DestroyBall.count.ToString();
    }

}

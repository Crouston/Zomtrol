using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Script that handle everything in the scene 
/// </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject losePanel,winPanel;

    public int starsGotten;

    public bool isLosing;

    public List<GoalHandler> goals;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        starsGotten = 0;
        isLosing = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartOver();
        CheckLose();
        CheckWin();
    }

    //Function that happen when lose condition have been met
    private void Lose()
    {
        losePanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    //Check when to lose 
    private void CheckLose()
    {
        if (isLosing)
        {
            Lose();
        }
    }

    //Check when to win
    private void CheckWin()
    {
        foreach(GoalHandler goal in goals)
        {
            if(goal.isPressed == false)
            {
                return;
            }
        }
        Win();
    }

    //Function that called when winning
    private void Win()
    {
        winPanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    //Player can retry when pressing space
    private void StartOver()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(Application.loadedLevel);
        }
    }
}

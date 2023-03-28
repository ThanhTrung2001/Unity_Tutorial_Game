using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
  int score = 0;
  bool isGameOver = false;

  public static GameController Instance{get; private set;}
  private void Awake() 
  {
    if (Instance != null && Instance != this) 
    { 
        Destroy(this); 
    } 
    else 
    { 
        Instance = this; 
    } 
  }

  public void SetGameOver()
  {
    isGameOver = true;
    GameObject.Find("EnemySpawnController").GetComponent<EnemySpawnController>().StopSpawningEnemy();
    UIManager.Instance.ShowOverPanel(score);
  }

  public void IncreaseScore()
  {
    if (isGameOver == false)
    {
      score++;
      UIManager.Instance.UpdateScore(score);
    }
  }

  public bool checkGameOver()
  {
    if(isGameOver == false)
    {
      return false;
    }
    else 
    {
      return true;
    }
  }

  public void SetScore()
  {
    score = 0;
  }

  public void Replay()
  {
    SceneManager.LoadScene("GamePlay");
  }

  public void Menu()
  {
    SceneManager.LoadScene("Menu");
  }

  public void Pause()
  {
    UIManager.Instance.ShowResume();
    Time.timeScale = 0;
  } 

  public void Resume()
  {
    UIManager.Instance.ShowPause();
    Time.timeScale = 1;
  } 
}

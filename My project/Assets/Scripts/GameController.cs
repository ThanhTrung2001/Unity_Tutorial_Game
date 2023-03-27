using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
  }

  public void IncreaseScore()
  {
    if (isGameOver == false)
    {
      score++;
      UIManager.Instance.UpdateScore(score);
    }
  }

  public void SetScore()
  {
    score = 0;
  } 
}

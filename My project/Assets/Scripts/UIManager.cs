using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
  public TextMeshProUGUI scoreText;
  public TextMeshProUGUI scoreShowing;
  public GameObject pause;
  public GameObject resume;
  public GameObject gameOverPanel;
  public static UIManager Instance{get; private set;}
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
  // Start is called before the first frame update
  void Start()
  {
    scoreText.text = "0";
    ShowPause();
  }

  // Update is called once per frame
  void Update()
  {
        
  }

  public void UpdateScore(int score)
  {
    scoreText.text = score.ToString();
  }

  public void ShowOverPanel(int score)
  {
    scoreShowing.text = $"Score: {score}";
    gameOverPanel.SetActive(true);
    pause.SetActive(false);
    resume.SetActive(false);
  }

  public void SetScore()
  {
    scoreText.text = "0";
    scoreShowing.text = "0";
    gameOverPanel.SetActive(false);
  }

  public void ShowPause()
  {
    pause.SetActive(true);
    resume.SetActive(false);
  }

  public void ShowResume()
  {
    pause.SetActive(false);
    resume.SetActive(true);
  }
}

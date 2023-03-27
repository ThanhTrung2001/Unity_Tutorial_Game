using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
  public TextMeshProUGUI scoreText;
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
  }

  // Update is called once per frame
  void Update()
  {
        
  }

  public void UpdateScore(int score)
  {
    scoreText.text = score.ToString();
  }
}

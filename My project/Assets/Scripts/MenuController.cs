using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
  public static MenuController Instance{get; private set;}
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
  public void Play()
  {
      SceneManager.LoadScene("GamePlay");
  }
}

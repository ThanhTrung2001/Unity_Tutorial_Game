using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
  float rotateSpeed = 5f;
  public GameObject dust;
  Rigidbody2D rb2d;
  // Start is called before the first frame update
  void Start()
  {
        
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    Rotation();
  }

  void Rotation()
  {
    transform.Rotate(0, 0 , rotateSpeed);
  }

  private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.CompareTag("Player"))
    {
      GameController.Instance.SetGameOver();
    }
    else if(other.gameObject.CompareTag("Ground"))
    {
      GameController.Instance.IncreaseScore();
      gameObject.SetActive(false);
      GameObject dustEffect = Instantiate(dust, transform.position, Quaternion.identity);
      Destroy(dustEffect, 1f);
      Destroy(gameObject);
    }
  }

}

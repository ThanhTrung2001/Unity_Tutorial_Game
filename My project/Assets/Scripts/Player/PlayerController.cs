using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  float xLimit = 2.3f;
  float speed = 3f;
  Rigidbody2D rb2d;
  // Start is called before the first frame update
  void Start()
  {
    rb2d = GetComponent<Rigidbody2D>();
  }

  // FixedUpdate is called once per frame for Physics
  void FixedUpdate()
  {
    Moving();
  }

  //Moving
  void Moving()
  {
    if(GameController.Instance.checkGameOver() == false)
    {
      Vector3 newPosition = transform.position;
      newPosition.x += Input.GetAxis("Horizontal")*speed*Time.deltaTime;
      newPosition.x = Mathf.Clamp(newPosition.x, -xLimit, xLimit); 
      rb2d.MovePosition(newPosition);
    }
  }

  //Jumping
  void Jumping()
  {

  }

}

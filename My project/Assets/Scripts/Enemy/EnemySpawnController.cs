using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
  public GameObject enemy;
  float spawnRate= 1f;
  float xLimitSpawn = 2.3f;
  // Start is called before the first frame update
  void Start()
  {
    StartSpawningEnemy(); 
  }

  // Update is called once per frame
  void Update()
  {
        
  }

  //Spawn Enemy
  void SpawnEnemy()
  {
    float randomInRange = Random.Range(-xLimitSpawn, xLimitSpawn);
    Vector2 spawnPosition = new Vector2(randomInRange, 5.9f);
    Instantiate(enemy, spawnPosition, Quaternion.identity);
  }

  //Start Play Game
  void StartSpawningEnemy()
  {
    InvokeRepeating("SpawnEnemy", 1f , spawnRate);
  }
  //End Level / Die
  public void StopSpawningEnemy()
  {
    CancelInvoke("SpawnEnemy");
  }
}


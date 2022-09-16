using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer=0;
    float timeToMove=0.5f;
    int numberOfMovements=0;
    float speed = 0.25f;

    public GameObject EnemyProjectile;
    public GameObject EnemyProjectileClone;
    public GameObject enemy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (GameManager.playGame){
        timer += Time.deltaTime;
        if (timer > timeToMove && numberOfMovements < 5)
        {
          transform.Translate(new Vector3(speed, 0, 0));
          timer=0;
          numberOfMovements++;
        }
        if (numberOfMovements==5)
        {
          transform.Translate(new Vector3(0, -0.5f, 0));
          numberOfMovements=-1;
          speed=-speed;
          timer=0;
        }
        fireEnemyProjectile();
          }
      }


    void fireEnemyProjectile()
    {
      if (Random.Range(0f,800f)<0.1){
        EnemyProjectileClone=Instantiate(EnemyProjectile, new Vector3(enemy.transform.position.x,enemy.transform.position.y-0.4f,0), enemy.transform.rotation) as GameObject;
      }
    }
}

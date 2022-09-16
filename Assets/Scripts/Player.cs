using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject projectile;
    public GameObject projectileClone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (GameManager.lives > 0)
      {
      movement();
      fireProjectile();
      }
    }

void movement()
{
  if (Input.GetKey(KeyCode.RightArrow))
  {
    if (player.transform.position.x>4.3)
    {
      if (GameManager.enemies==0 && player.transform.position.x<18)
      {
        transform.Translate(new Vector3(7*Time.deltaTime, 0, 0));
      }
    }
    else
    {
      transform.Translate(new Vector3(7*Time.deltaTime, 0, 0));
    }
  }
  if (Input.GetKey(KeyCode.LeftArrow))
  {
    if (player.transform.position.x<-4.3)
    {}
    else
    {
    transform.Translate(new Vector3(-7*Time.deltaTime, 0, 0));
    }
  }
  if (Input.GetKey(KeyCode.UpArrow))
  {
    if (player.transform.position.y>4)
    {}
    else
    {
    transform.Translate(new Vector3(0, -7*Time.deltaTime, 0));
    }
  }
  if (Input.GetKey(KeyCode.DownArrow))
  {
    if (player.transform.position.y<-4)
    {}
    else
    {
      transform.Translate(new Vector3(0,7*Time.deltaTime, 0));
    }
  }
}
void fireProjectile()
{
  if (Input.GetKeyDown(KeyCode.Space)&& projectileClone == null)
  {
    projectileClone=Instantiate(projectile, new Vector3(player.transform.position.x,player.transform.position.y+0.6f,0), player.transform.rotation) as GameObject;
  }

}


}

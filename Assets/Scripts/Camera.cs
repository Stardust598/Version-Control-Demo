using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //public GameObject player;
    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (player.transform.position.x>4.4)
      {
        transform.position = new Vector3(player.position.x, 0, -10);
      }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives=3;
    public static int enemies=27;
    public static bool playGame=true;
    public Text LivesText;
    public Text endScreen;
    public Text hiddenEndScreen;
    // Start is called before the first frame update
    void Start()
    {
      LivesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
      LivesText.text = "Lives: " + lives;
      if (lives == 0){
        endScreen.text= "You Lose!";
        GameManager.playGame = false;
      }
      if (Earth.win == 1){
        endScreen.text= "You returned to Earth!";
          GameManager.lives = 0;
      }
    }
}

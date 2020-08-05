using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    [SerializeField] static int gameTime = 10;
    // Start is called before the first frame update
   
    public static bool GetCheckTime()
    {
        return gameTime - Time.timeSinceLevelLoad >= 0;
    }
  

    // Update is called once per frame
   
}

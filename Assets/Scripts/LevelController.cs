using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField]
    int countOfEnemies=0;
    
   
    public  void AddInstance()
    {
        countOfEnemies++;
    }
    public  void RemoveInstance()
    {
        countOfEnemies--;
        CompleteLevel();
    }
    private  void CompleteLevel()
    {
        if(countOfEnemies==0 && !GameTimer.GetCheckTime())
        {

            FindObjectOfType<LifesCounter>().GetWinLabel();

        }
    }
    
}

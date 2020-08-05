using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int cost=0;
    // Start is called before the first frame update
    
    public int GetStartCost()
    {
        return cost;
    }
    void AddScore(int add)
    {
        StarDisplay display = FindObjectOfType<StarDisplay>();
        display.AddStar(add);
    }
    // Update is called once per frame
 
}

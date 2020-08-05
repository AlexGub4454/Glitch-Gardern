using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool needToSpawn = true;
    [SerializeField] float minTime;
    [SerializeField] float maxTime;
    [SerializeField] Attacker[] attackers;
    Attacker attacker;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (needToSpawn)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            Spawn();
            
        }
    }
     
    void Spawn()
    {
        System.Random random = new System.Random();
        attacker = attackers[random.Next(0, attackers.Length)];
       Attacker newAttacker  = Instantiate(attacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent =gameObject.transform;
        FindObjectOfType<LevelController>().AddInstance();

    }
   
    // Update is called once per frame
    void Update()
    {
        needToSpawn = GameTimer.GetCheckTime();
    }
}

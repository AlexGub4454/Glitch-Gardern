using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Shoot : MonoBehaviour
{
   [SerializeField] GameObject gun, projectile;
   [SerializeField] AttackerSpawner mylaneSpawner;
    Animator animator;
    // Start is called before the first frame update
 
    void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }
    // Update is called once per frame
    private void Start()
    {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }
    void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("shoot");
            animator.SetBool("IsActive", true);
        }
        else
        {
            Debug.Log("neshoot123");
            animator.SetBool("IsActive", false);
        }
    }
   
   
    void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach(var spawner in spawners)
           {
               bool isClosed = Mathf.Abs(spawner.transform.position.y - gameObject.transform.position.y) <= Mathf.Epsilon;
               if (isClosed)
               {
                   mylaneSpawner = spawner;
                   return;
               }
           }
       // mylaneSpawner = spawners.Select(n => Mathf.Abs(n.transform.position.y - gameObject.transform.position.y) <= Mathf.Epsilon) as AttackerSpawner;
    }
    bool IsAttackerInLane()
    {
        if (mylaneSpawner.transform.childCount > 0)
        {
            return true;
        }
        else { return false; }
    }
}

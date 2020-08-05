using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    [SerializeField] float unitSpeed;
    GameObject currentObject;
    [SerializeField] float damage;

    public void Attack(GameObject gameObject)
    {
        currentObject = gameObject;
        GetComponent<Animator>().SetBool("IsAttacking", true);

    }
    void Eating()
    {
        currentObject?.GetComponent<Health>().DealDamage(damage);
    }
  
    public void SetSpeed(float speed)
    {
        unitSpeed = speed;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * unitSpeed);
        if (!currentObject)
        {
            GetComponent<Animator>().SetBool("IsAttacking", false);
        }
    }
}

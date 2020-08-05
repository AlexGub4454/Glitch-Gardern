using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed =1f;
    [SerializeField] float damage=50f;
   
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.gameObject.GetComponent<Health>();
        var attacker = collision.gameObject.GetComponent<Attacker>();
        health.DealDamage(damage);
        if (health && attacker)
        {
            
            Destroy(gameObject);
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}

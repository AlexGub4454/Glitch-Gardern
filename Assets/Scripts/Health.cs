using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject VFX;
    [SerializeField] float health = 100f;
    // Start is called before the first frame update

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            DeathVFX();
            
          if(gameObject.GetComponent<Attacker>())
                FindObjectOfType<LevelController>().RemoveInstance();
            Destroy(gameObject);
        }
    }
    void DeathVFX()
    {
        if (!VFX) { return; }
        GameObject gameObjectVFX = Instantiate(VFX, transform.position, transform.rotation);
        Destroy(gameObjectVFX, 1f);
    }
    // Update is called once per frame
  
}

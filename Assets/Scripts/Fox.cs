using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Defender>())
        {
            if (collision.gameObject.tag == "Grave") 
            {
                GetComponent<Animator>().SetTrigger("isJumping");
            }
            else
            {
                GetComponent<Attacker>().Attack(collision.gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

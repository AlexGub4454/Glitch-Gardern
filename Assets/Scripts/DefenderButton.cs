using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defender;
    Defender def;

    private void Awake()
    {
        def = defender;
    }
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton but in buttons)
        {
            but.GetComponent<SpriteRenderer>().color = Color.black;
        }
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetDefender(defender);
        
    }
    private void Update()
    {
        defender = def;
    }
    // Start is called before the first frame update

}

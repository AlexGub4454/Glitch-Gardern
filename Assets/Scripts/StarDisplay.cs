using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarDisplay : MonoBehaviour
{
    [SerializeField] int star;
    Text text;
    void UpdateDisplay()
    {
        text.text = star.ToString();
    }
    // Start is called before the first frame update
   
    void Start()
    {
        text = GetComponent<Text>();
        UpdateDisplay();
    }
    public bool CanBuy(int cost)
    {
        return star >= cost;
    }
    public void AddStar(int add)
    {
        star += add;
        UpdateDisplay();
    }
    public void SpendStar(int add)
    {
        if(star>=add)
        star -= add;
        UpdateDisplay();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

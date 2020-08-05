using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] Defender defender;
    // Start is called before the first frame update

    public void SetDefender(Defender def)
    {
        defender = def;
    }
    private void OnMouseDown()
    {

        GetTryToBuy(GetSquareClick());
    }
    private void GetTryToBuy(Vector2 pos) {
        var Star = FindObjectOfType<StarDisplay>();
        if (Star.CanBuy(defender.GetStartCost()))
        {
            Star.SpendStar(defender.GetStartCost());
            InstanceGameObject(pos);
        }
    }
    private Vector2 GetSquareClick()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 squarePos = Camera.main.ScreenToWorldPoint(mousePos);
        return RoundVector(squarePos);       
    }
    
    private Vector2 RoundVector(Vector2 vector)
    {
        Vector2 Rounded = new Vector2(Mathf.RoundToInt(vector.x), Mathf.RoundToInt(vector.y));
        return Rounded;
    }
    private void InstanceGameObject(Vector2 vector2)
    {
       Defender def = Instantiate(defender, vector2, Quaternion.identity) as Defender;
    }
    // Update is called once per frame
   
}

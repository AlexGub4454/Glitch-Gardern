using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LifesCounter : MonoBehaviour
{
    [SerializeField] GameObject loseText;
    [SerializeField] GameObject winText;
    [SerializeField] Text lifeCounter;
    [SerializeField] int lifes;
    [SerializeField] float secondsBeforeNewLevel=2f;
    // Start is called before the first frame update
    
    public void GetWinLabel()
    {
        StartCoroutine(WinGame());
    }
    IEnumerator WinGame()
    {
        winText.SetActive(true);
        yield return new WaitForSeconds(secondsBeforeNewLevel);
        FindObjectOfType<LevelLoader>().LoadNextScene();
        
    }
    void UpdateText()
    {
        lifeCounter.text = lifes.ToString();

    }

    private void Awake()
    {
        lifes = Options.GetPrefsNum();
    }
    void Start()
    {
        loseText.SetActive(false);
        winText.SetActive(false);
        lifeCounter.text = lifes.ToString();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Attacker>())
        {

            lifes--;
            collision.gameObject.GetComponent<Health>().DealDamage(10000);
            if (lifes > 0)
                UpdateText();
            else
            {

                loseText.SetActive(true);
                Time.timeScale = 0f;

            }
        }
    }
}
    // Update is called once per frame
   

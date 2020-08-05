using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
    [SerializeField] float timeForWait;
    // Start is called before the first frame update
    
    public void LoadCurrentscene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(1+currentSceneIndex);
        
    }
    public void QuitApp()
    {
        Application.Quit();
    }
    IEnumerator WaitForTime()
    {
        yield return  new WaitForSeconds(timeForWait);
        LoadNextScene();
    }
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

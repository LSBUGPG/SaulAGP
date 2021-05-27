using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public Animation animations;
    public float transitionTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 
    public void QuitGame()
    {

        Application.Quit();
    }

    public void Loadlevel()
    {
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        Debug.Log("loadlevel");
    }
   
    IEnumerator loadLevel(int levelIndex)
    {
        animations.Play();
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);

    }
    public void loadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

public void levelSelection()
{
        SceneManager.LoadScene("levelSelection");
    }

 public void loadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void loadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void loadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}

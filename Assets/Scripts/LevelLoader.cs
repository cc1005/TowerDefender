using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    int currentSceneIndex;
    [SerializeField] int waitInSecondsForLoad = 4;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForScene());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitForScene()
    {
        yield return new WaitForSeconds(waitInSecondsForLoad);
        loadNextScene();
    } 
    public void loadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}

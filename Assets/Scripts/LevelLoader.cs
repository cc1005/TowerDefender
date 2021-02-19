using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        loadStartScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void loadStartScene()
    {
        StartCoroutine(loadStartSceneWithDelay());
    }

    private IEnumerator loadStartSceneWithDelay()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}

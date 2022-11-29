using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void SceneNewLoader(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void SceneNewUnloader(string name)
    {
        SceneManager.UnloadScene(name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JordanDjequickButtonCode : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadSceneAsync(5);
    }
}

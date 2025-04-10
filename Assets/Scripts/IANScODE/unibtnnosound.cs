using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unibtnnosound : MonoBehaviour
{
    [SerializeField]
    private string SceneToGoTO;
    public void OnButtonPress()
    {
        SceneManager.LoadScene(SceneToGoTO);
    }
}

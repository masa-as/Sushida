using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void GoTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void GoSelect()
    {
        SceneManager.LoadScene("Select");
    }

    public void GoStartBefore()
    {
        SceneManager.LoadScene("StartBefore");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void GoSelect()
    {
        SceneManager.LoadScene("Select");
    }

    public void GoStartBefore()
    {
        SceneManager.LoadScene("StartBefore");
    }

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject kokokara;
    public GameObject setumei;
    public GameObject text;
    public GameObject start;
    private GameObject ita_R;
    private GameObject ita_L;

    // Start is called before the first frame update
    void Start()
    {
        //kokokara = GameObject.Find("kokokara");
        //setumei = GameObject.Find("setumei");
        //text = GameObject.Find("text");
        ita_R = GameObject.Find("ita_R");
        ita_L = GameObject.Find("ita_L");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            kokokara.SetActive(false);
            setumei.SetActive(false);
            text.SetActive(false);
            Invoke("ChangeScene1", 1.0f);
        }
    }

    private void ChangeScene1()
    {
        start.SetActive(true);
        Invoke("ChangeScene2", 0.5f);
    }

    private void ChangeScene2()
    {
        ita_R.transform.Translate(2.0f, 0, 0);
        ita_L.transform.Translate(-2.0f, 0, 0);
        Invoke("ChangeScene3", 0.5f);
    }

    private void ChangeScene3()
    {
        SceneManager.LoadScene("Game");
    }
}

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
	Vector3 target = new Vector3(9, 0, 0);

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kokokara.SetActive(false);
            setumei.SetActive(false);
            text.SetActive(false);
            Invoke("ChangeScene1", 0.5f);
        }
    }

    private void ChangeScene1()
    {
        start.SetActive(true);
        Invoke("ChangeScene2", 0.5f);
    }

    private void ChangeScene2()
    {
        Invoke("ChangeScene3", 1.0f);
        while (true)
        {
            ita_R.transform.position = Vector3.Lerp(ita_R.transform.position, target, Time.deltaTime);
            // ita_R.transform.Translate(1.0f, 0, 0);
            ita_L.transform.Translate(-1.0f, 0, 0);
            if(ita_L.transform.position.x > -9)
            {
                break;
            }
        }
    }

    private void ChangeScene3()
    {
        SceneManager.LoadScene("Game");
    }
}

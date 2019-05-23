using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject text;
    public GameObject start;
    private GameObject kokokara;
    private GameObject setumei;
    private GameObject tatesen;
    private GameObject ita_R;
    private GameObject ita_L;
    Rigidbody rb_R;
    Rigidbody rb_L;
    Vector3 target = new Vector3(9, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        //kokokara = GameObject.Find("kokokara");
        //setumei = GameObject.Find("setumei");
        //text = GameObject.Find("text");
        ita_R = GameObject.Find("ita_R");
        ita_L = GameObject.Find("ita_L");
        tatesen = GameObject.Find("tatesen");
        setumei = GameObject.Find("setumei");
        kokokara = GameObject.Find("kokokara");
        rb_R = ita_R.GetComponent<Rigidbody>();
        rb_L = ita_L.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kokokara.SetActive(false);
            setumei.SetActive(false);
            text.SetActive(false);
            tatesen.SetActive(false);
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
        rb_R.AddForce(1, 0, 0, ForceMode.Impulse);
        rb_L.AddForce(-1, 0, 0, ForceMode.Impulse);
        //ita_R.transform.Translate(0.2f, 0, 0);
        //ita_L.transform.Translate(-0.2f, 0, 0);
        Invoke("ChangeScene3", 1.0f);

        //while (true)
        //{
        //    ita_R.transform.position = Vector3.Lerp(ita_R.transform.position, target, Time.deltaTime);
        //    // ita_R.transform.Translate(1.0f, 0, 0);
        //    ita_L.transform.Translate(-1.0f, 0, 0);
        //    if(ita_L.transform.position.x > -9)
        //    {
        //        break;
        //    }
        //}
    }

    private void ChangeScene3()
    {
        SceneManager.LoadScene("Game");
    }
}

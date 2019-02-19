using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour 
{
	public Text timerText;
	public float totalTime;
    public GameObject finish;
    private GameObject ita_R;
    private GameObject ita_L;
    private GameObject typingObject;
    int seconds;

	// Use this for initialization
	void Start () 
	{
        typingObject = GameObject.Find("TypingObject");
        ita_R = GameObject.Find("ita_R");
        ita_L = GameObject.Find("ita_L");
    }

    // Update is called once per frame
    void Update () 
	{
		totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
        if (seconds >= 100)
        {
            timerText.text = seconds.ToString();
        }
        else if(seconds >= 10)
        {
            timerText.text = "0" + seconds.ToString();
        }
        else
        {
            timerText.text = "00" + seconds.ToString();
        }

        if (seconds <= 0)
        {
            finish.SetActive(true);
            typingObject.SetActive(false);
            Invoke("ItaMove", 0.5f);
        }
    }

    void ItaMove()
    {
        ita_R.transform.Translate(-0.2f, 0, 0);
        ita_L.transform.Translate(0.2f, 0, 0);
        Invoke("ChangeScene", 0.5f);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("result");
    }
}
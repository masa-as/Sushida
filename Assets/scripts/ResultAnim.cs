using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultAnim : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public GameObject third;
    public GameObject fourth;
    public GameObject fifth;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("First", 0.5f);
    }
    void First()
    {
        first.SetActive(true);
        Invoke("Second", 0.5f);
    }
    void Second()
    {
        second.SetActive(true);
        Invoke("Third", 0.5f);
    }
    void Third()
    {
        third.SetActive(true);
        Invoke("Fourth", 0.5f);
    }
    void Fourth()
    {
        fourth.SetActive(true);
        Invoke("Fifth", 0.5f);
    }
    void Fifth()
    {
        fifth.SetActive(true);
    }

}

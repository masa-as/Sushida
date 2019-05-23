using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispTypeSpeed : MonoBehaviour
{
    private Text targetText;
    // Start is called before the first frame update
    void Start()
    {
        float speed;
        float time=30f;
        speed = TypeObject.count / time;
        this.targetText = this.GetComponent<Text>(); // <---- 追加3
        this.targetText.text = speed.ToString(); // <---- 追加4
    }

    // Update is called once per frame
    void Update()
    {

    }
}

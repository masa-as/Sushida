using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispMissType : MonoBehaviour
{
    private Text targetText;
    // Start is called before the first frame update
    void Start()
    {
        this.targetText = this.GetComponent<Text>(); // <---- 追加3
        this.targetText.text = TypeObject.miss.ToString(); // <---- 追加4
    }

    // Update is called once per frame
    void Update()
    {

    }
}

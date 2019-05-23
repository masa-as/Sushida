using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(TypeObject.textLength/10f+0.3f, 0.575f, 1);

    }
}

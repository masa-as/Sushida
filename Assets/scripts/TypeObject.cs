using UnityEngine;
using System.Collections;

public class TypeObject : MonoBehaviour {

	public TextMesh stringTextMesh;
	public TextMesh alphabetTextMesh;
	public Dictionary dictionary;
    GameObject Slider;
    RendaBarCtrl rendaBarCtrl;
    public static　float textLength=0;

    TypingSystem ts;

	string[] keys = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", 
		"k", "l", "m", "n", "o", "p", "q", "r", "s", "t", 
		"u", "v", "w", "x", "y", "z", "-",};


	// Use this for initialization
	void Start () 
	{
        Slider = GameObject.Find("Slider");
        rendaBarCtrl = Slider.GetComponent<RendaBarCtrl>();
        ts = new TypingSystem ();
		ts.SetInputString (dictionary.GetRandomWord());

		UpdateText ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		foreach (string key in keys) 
		{
			if(Input.GetKeyDown(key))
			{
				if (ts.InputKey (key) == 1) 
				{
                    //入力成功
                    rendaBarCtrl.renda -= 0.01f;
					UpdateText ();
                }
                else {
                    //ミスをしたら
                    rendaBarCtrl.renda = 1.0f;
                }
                break;
			}
		}
		if (ts.isEnded ()) 
		{
			ts.SetInputString (dictionary.GetRandomWord());
			UpdateText ();
		}
	}

	void UpdateText()
	{
		stringTextMesh.text =  ts.GetInputedString() + ts.GetRestString();
		alphabetTextMesh.text = "<color=#777777>" + ts.GetInputedKey() + "</color>" + ts.GetRestKey();
        textLength = stringTextMesh.text.Length;
        //Debug.Log("Length : " + textLength);
    }
}

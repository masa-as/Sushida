using UnityEngine;
using System.Collections;

public class TypeObject : MonoBehaviour {

	public TextMesh stringTextMesh;
	public TextMesh alphabetTextMesh;
	public Dictionary dictionary;

	TypingSystem ts;

	string[] keys = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", 
		"k", "l", "m", "n", "o", "p", "q", "r", "s", "t", 
		"u", "v", "w", "x", "y", "z", "-",};


	// Use this for initialization
	void Start () 
	{
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
					UpdateText ();
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
		stringTextMesh.text = "<color=red>" + ts.GetInputedString() + "</color>" + ts.GetRestString();
		alphabetTextMesh.text = "<color=red>" + ts.GetInputedKey() + "</color>" + ts.GetRestKey();
	}
}

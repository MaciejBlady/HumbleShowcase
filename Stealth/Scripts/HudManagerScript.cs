using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HudManagerScript : MonoBehaviour {
	public GameObject mainText;

	// Use this for initialization
	void Start () {
		mainText = GameObject.FindGameObjectWithTag ("MainText");
		GameplayManagerScript.instance.hudManager = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void WinMessage()
	{

		var text = mainText.GetComponent<Text>();
		text.enabled = true;
		text.text= "WIN!!!";
	}

	public void DetectionMessage()
	{
		var text = mainText.GetComponent<Text>();
		text.enabled = true;
		text.text = "FAIL!!!";
	}
}

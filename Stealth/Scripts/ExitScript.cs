using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {

	public GameObject gameplayManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
			GameplayManagerScript.instance.achieveWinCondition ();
	}
}

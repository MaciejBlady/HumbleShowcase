using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public bool player = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PushTheButton()
	{
		Animator anim = GetComponentInParent<Animator>();

		if (anim.GetBool ("Open")) {
			anim.SetBool ("Open", false);
			anim.SetBool ("Close", true);
		} else if (anim.GetBool ("Close")) {
			anim.SetBool ("Open", true);
			anim.SetBool ("Close", false);
		}


	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Player") {
			PushTheButton ();
			player = ! player;
		}
	}
}

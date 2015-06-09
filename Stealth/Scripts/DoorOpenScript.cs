using UnityEngine;
using System.Collections;

public class DoorOpenScript : MonoBehaviour {

	public bool open = false;
	public bool close = false;
	public float openSpeed = 20.0f;
	public bool stopOpening = false;
	public bool stopClosing = false;

	public float OpeningTimer = 0.0f;
	public float OpenDuration = 3.0f;
	public bool DontClose = false;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Open && !StopOpening) {
			this.transform.position += new Vector3(0,-OpenSpeed*Time.deltaTime,0);

			if((-this.transform.position.y) > this.transform.localScale.y/2)
			{
				StopOpening = true;
				//Open = false;
			}

		}

		if (Open && !DontClose) {
			OpeningTimer+=Time.deltaTime;
			if(OpeningTimer >= OpenDuration)
			{
				Close = true;
				Open = false;
				StopOpening = false;
				OpeningTimer = 0;
			}
		}

		if (Close) {

			this.transform.position += new Vector3(0,OpenSpeed*Time.deltaTime,0);
			
			if((this.transform.position.y) >= 0.0f)
			{
				//StopClosing = true;
				Close = false;
				this.transform.localPosition = new Vector3(0,0,0);
			}
		}



	}

	public void OpenDoors()
	{
		Open = true;
	}
}

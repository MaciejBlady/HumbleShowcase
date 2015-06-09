using UnityEngine;
using System.Collections;

public class EnemySightScript : MonoBehaviour {
	public GameObject gameplayManager;
	public float sightDistance = 8.0f;
	public float FOV = 120.0f;


	public float colorStep = 500.0f;
	public float detectionGainStep = 50.0f;
	public float detectionLooseStep = 50.0f;
	public float detectionThreshold = 100.0f;
	public float detectionTimer = 0.0f;
	public float detectionDuration = 5.0f;



	public float detection = 0.0f;

	public bool PlayerSighted = false;
	public bool PlayerDetected =false;

	private Vector3 playerPosition;
	private Color standartColor;
	

	// Use this for initialization
	void Start () {
		standartColor = this.gameObject.GetComponent<MeshRenderer> ().material.color;
		//gameplayManager = GameObject.FindGameObjectWithTag ("GameplayManager");

	}
	
	// Update is called once per frame
	void Update () {

		PlayerSighted = playerInSight ();
		if (PlayerSighted && detection <= detectionThreshold) {

			detection += detectionGainStep*Time.deltaTime*(1.0f/getDistanceToPlayer());
			this.gameObject.GetComponent<MeshRenderer> ().material.color += new Color (detection/colorStep, detection/colorStep, detection/colorStep);

		} else {
			if(detection > 0.0f)
				detection -=detectionLooseStep*Time.deltaTime;
			this.gameObject.GetComponent<MeshRenderer> ().material.color -= new Color (detection/colorStep, detection/colorStep, detection/colorStep);
		}

		if (detection >= detectionThreshold) {
			this.gameObject.GetComponent<MeshRenderer> ().material.color = Color.black;

			PlayerDetected = true;
			//gameplayManager.GetComponent<GameplayManagerScript>().setPlayerDetected();
			GameplayManagerScript.instance.setPlayerDetected();
		}

		if (detection <= 0) {
			this.gameObject.GetComponent<MeshRenderer> ().material.color = standartColor;
			detection = 0;
		}

		if(PlayerDetected && detection <=0.0f){
			detectionTimer +=Time.deltaTime;

			if(detectionTimer >=detectionDuration)
			{
				detectionTimer = 0.0f;
				PlayerDetected = false;
			}

		}
	}

	bool playerInSight()
	{
		playerPosition = GameObject.FindGameObjectWithTag ("Player").transform.position;
		Vector3 rayDirection = playerPosition - transform.position;
		
		RaycastHit rayHit;
		
		if(Physics.Raycast(transform.position,rayDirection,out rayHit))
		{
			if(rayHit.transform.tag == "Player")
			{
				if(rayHit.distance <= sightDistance)
				{
					if(Vector3.Angle(transform.forward,rayDirection) <= FOV)
					{
						return true;
					}
				}
			}
		}

		return false;
	}

	float getDistanceToPlayer()
	{
		return Vector3.Distance (playerPosition, transform.position);
	}
		
	void OnTriggerEnter(Collider other){

		if (other.tag == "Player") {
			detection = detectionThreshold;
		}
	}
}

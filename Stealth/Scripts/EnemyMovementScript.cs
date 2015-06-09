using UnityEngine;
using System.Collections;

public class EnemyMovementScript : MonoBehaviour
{
	
	public Transform[] waypoints;
	public float EnemySpeed = 10.0f;
	public int currentWaypoint = 0;
	NavMeshAgent agent;

	// Use this for initialization
	void Start ()
	{
		agent = this.GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GetComponent<EnemySightScript> ().PlayerSighted) {
			lookAtPlayerLastPosition (GameObject.FindGameObjectWithTag ("Player").transform.position);
		} else
		if (GetComponent<EnemySightScript> ().PlayerDetected)
			chasePlayer (GameObject.FindGameObjectWithTag ("Player").transform.position);
		else {
			patrol ();
		}
	}

	void patrol()
	{
		agent.Resume();
		if(agent.remainingDistance <= agent.stoppingDistance)
		{
			currentWaypoint++;
			
			if (currentWaypoint >= waypoints.Length)
				currentWaypoint = 0;
		}
		
		agent.SetDestination (waypoints [currentWaypoint].position);
	}

	void lookAtPlayerLastPosition(Vector3 lookAtPoint)
	{
		agent.Stop ();
		transform.LookAt (lookAtPoint);
	}

	void chasePlayer(Vector3 chasePoint)
	{
		agent.Resume();
		agent.SetDestination (chasePoint);
	}


}

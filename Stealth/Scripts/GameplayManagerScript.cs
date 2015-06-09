using UnityEngine;
using System.Collections;

public class GameplayManagerScript : MonoBehaviour {


	public GameObject hudManager;
	
	private static GameplayManagerScript _instance;

	public static GameplayManagerScript instance
	{
		get
		{
			if(_instance == null)
			{
				_instance = GameObject.FindObjectOfType<GameplayManagerScript>();
				DontDestroyOnLoad(_instance.gameObject);
			}
			
			return _instance;
		}

	}

	void Awake()
	{
		if(_instance == null)
		{
			//If I am the first instance, make me the Singleton
			_instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			//If a Singleton already exists and you find
			//another reference in scene, destroy it!
			if(this != _instance)
				Destroy(this.gameObject);
		}
	}

	void Start () {

	}

	void Update () {
		if (Input.GetButtonDown ("Cancel")) {
			Application.Quit();
		}
	}

	public void achieveWinCondition()
	{

		hudManager.GetComponent<HudManagerScript> ().WinMessage ();

		int nextLevelIndex = Application.loadedLevel + 1;

		if (nextLevelIndex > Application.levelCount - 1)
			nextLevelIndex = 0;

		Application.LoadLevel (nextLevelIndex);


	}

	public void setPlayerDetected()
	{

		hudManager.GetComponent<HudManagerScript> ().DetectionMessage ();

		Application.LoadLevel (Application.loadedLevel);
	}
}

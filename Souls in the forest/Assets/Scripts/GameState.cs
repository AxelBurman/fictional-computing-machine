using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	public static GameState Singleton = null;
	// Use this for initialization
	void Start () 
	{
		//DontDestroyOnLoad(gameObject);
		Singleton = this;
	}
	
	// Update is called once per frame
	void Update () 
	{

    }

	public GameObject GetPlayer()
	{
		return gameObject;
	}
}

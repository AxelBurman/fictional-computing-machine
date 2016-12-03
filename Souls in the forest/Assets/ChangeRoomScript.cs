using UnityEngine;
using System.Collections;

public class ChangeRoomScript : MonoBehaviour 
{
	public string m_NextRoom = "";

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.tag == "Player") 
		{
			DontDestroyOnLoad(coll.gameObject);
			Application.LoadLevel (m_NextRoom);
		}

	}
}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeRoomScript : MonoBehaviour 
{
	public string m_NextRoom = "";

	public string m_ConnectedTransision = "";

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
			
            SceneManager.LoadScene(m_NextRoom);
		}

	}
}

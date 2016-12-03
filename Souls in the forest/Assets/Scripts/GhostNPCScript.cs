using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class GhostNPCScript : MonoBehaviour
{
    public List<string> m_dialogueOnInteract = new List<string>();
    protected int m_CurrentMilestone = 0;
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void NextMilestone()
    {
        m_CurrentMilestone++;
    }

    void Interact()
    {
        Debug.Log(m_dialogueOnInteract[m_CurrentMilestone]);
    }
}

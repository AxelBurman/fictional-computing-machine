using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class GhostNPCScript : MonoBehaviour
{
    public List<GameObject> m_dialogueOnInteract = new List<GameObject>();
    protected int m_CurrentMilestone = 0;

    public TextMesh m_TextDisplay;

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
        if(m_CurrentMilestone > 0)
            m_dialogueOnInteract[m_CurrentMilestone -1].SetActive(false);

        m_dialogueOnInteract[m_CurrentMilestone].SetActive(true);
    }
}

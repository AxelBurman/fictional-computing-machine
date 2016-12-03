using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour
{

    private Transform m_CurrentInteractCollider;

    private bool m_IsInsideInteractCollider;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.I))
        {
            if(m_IsInsideInteractCollider)
            {
                m_CurrentInteractCollider.SendMessage("OnInteract");
            }
        }
	}

    void EnterInteract(Transform i_Trans)
    {
        m_CurrentInteractCollider = i_Trans;
        m_IsInsideInteractCollider = true;
    }

    void ExitInteract(Transform i_Trans)
    {
        m_CurrentInteractCollider = null;
        m_IsInsideInteractCollider = false;
    }
}

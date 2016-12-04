using UnityEngine;
using System.Collections;

public class InteractableScript : MonoBehaviour {

    public string m_MessageOnInteract = "";
    public Transform m_TargetObject;
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.SendMessage("EnterInteract", transform, SendMessageOptions.DontRequireReceiver);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        other.transform.SendMessage("ExitInteract", transform, SendMessageOptions.DontRequireReceiver);
    }

    void OnInteract()
    {
        m_TargetObject.SendMessage(m_MessageOnInteract);
    }
}

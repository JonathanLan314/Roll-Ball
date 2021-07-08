using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttach : MonoBehaviour
{
    public GameObject Player;

    public void OntOnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player touch");
            Player.transform.parent = transform;
        }
    }

    public void OntOnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.transform.parent = null;
        }
    }
}

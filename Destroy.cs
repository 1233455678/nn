using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (col.gameObject.tag == "Player"){
        Destroy(gameObject);
        }        
    }
}

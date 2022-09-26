using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTouch : MonoBehaviour
{
    //[SerializeField] private GameObject cube;

    private Material cubeMaterial;
    private void Start()
    {
        cubeMaterial = GetComponent<Renderer>().material;
    }

    private void OnCollisionStay(Collision other) {
        if (other.gameObject.tag == "Ball") {
            this.GetComponent<Renderer>().material = other.gameObject.GetComponent<Renderer>().material;
            Debug.LogAssertion("Cube touched Ball");
        }
    }

    private void OnCollisionExit(Collision other) {
        if (other.gameObject.tag == "Ball") {
            this.GetComponent<Renderer>().material = cubeMaterial;
            Debug.LogAssertion("Cube untouched Ball");
        }    
    }
}

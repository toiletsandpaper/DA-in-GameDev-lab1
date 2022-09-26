using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundController : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "MainCamera")
            Destroy(other.gameObject);
    }
}

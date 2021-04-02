using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DupeGen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out BlockGen blockGen))
        {
            blockGen.IsDupe = true;
        }
    }
}

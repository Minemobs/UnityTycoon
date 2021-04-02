using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{

    public float speed;
    public GameObject endPoint;
    public List<GameObject> onBelt;

    private void OnCollisionStay(Collision other)
    {
        var position = endPoint.transform.position;
        var otherPosition = other.transform.position;
        otherPosition =
            Vector3.MoveTowards(otherPosition, new Vector3(position.x, otherPosition.y, position.z), speed * Time.deltaTime);
        other.transform.position = otherPosition;
    }
}

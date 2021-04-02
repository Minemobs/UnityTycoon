using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject cube;
    public int generateMoney;
    public int timeInSeconds;

    private void Start()
    {
        InvokeRepeating(nameof(GenerateCube), 2f, timeInSeconds);
    }

    private void GenerateCube()
    {
        Quaternion rotation = transform.rotation;
        cube.SetActive(true);
        Instantiate(cube, transform.position, new Quaternion(rotation.x, 90f, rotation.z, rotation.w));
    }
}
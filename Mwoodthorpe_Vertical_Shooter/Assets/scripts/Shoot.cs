using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform spawnLocation;
    [SerializeField] private GameObject laser;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    private void Fire()
    {
       Instantiate(laser, spawnLocation.position, spawnLocation.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMotion : MonoBehaviour
{
    public Transform centerofMass;
    public float orbitalSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        Orbit();
    }
    void Orbit()
    {
        transform.RotateAround(centerofMass.position, Vector3.up, orbitalSpeed*Time.deltaTime);
    }
}

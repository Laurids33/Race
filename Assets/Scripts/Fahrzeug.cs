using UnityEngine;

public class Fahrzeug : MonoBehaviour
{
    readonly float drehmomentFaktor = 25000;
    public WheelCollider collVL, collVR, collHL, collHR;

    void Update()
    {
        float drehmoment = drehmomentFaktor * Time.deltaTime * Input.GetAxis("Vertical");
        collVL.motorTorque = drehmoment;
        collVR.motorTorque = drehmoment;
        collHL.motorTorque = drehmoment;
        collHR.motorTorque = drehmoment;
    }
}
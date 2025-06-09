using UnityEngine;

public class Fahrzeug : MonoBehaviour
{
    readonly float drehmomentFaktor = 15000;
    public WheelCollider collVL, collVR, collHL, collHR;
    readonly float lenkwinkelFaktor = 30;
    public GameObject radVL, radVR;

    void Update()
    {
        float drehmoment = drehmomentFaktor * Time.deltaTime * Input.GetAxis("Vertical");
        collVL.motorTorque = drehmoment;
        collVR.motorTorque = drehmoment;
        collHL.motorTorque = drehmoment;
        collHR.motorTorque = drehmoment;

        float lenkwinkel = lenkwinkelFaktor * Input.GetAxis("Horizontal");
        collVL.steerAngle = lenkwinkel;
        collVR.steerAngle = lenkwinkel;

        radVL.transform.localEulerAngles = new Vector3(
            radVL.transform.localEulerAngles.x,
            collVL.steerAngle,
            radVL.transform.localEulerAngles.z
        );
        radVR.transform.localEulerAngles = new Vector3(
            radVR.transform.localEulerAngles.x,
            collVR.steerAngle,
            radVR.transform.localEulerAngles.z
        );
    }
}
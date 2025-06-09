using UnityEngine;
using UnityEngine.Video;

public class KameraBewegen : MonoBehaviour
{
    public GameObject fahrzeug;
    readonly float abstandXZ = 6;
    readonly float hoeheY = 4;

    void Update()
    {
        Quaternion fahrzeugRotationY = new Quaternion();
        fahrzeugRotationY.eulerAngles = new Vector3(0, fahrzeug.transform.eulerAngles.y, 0);
        Vector3 abstandHinterFahrzeug = fahrzeugRotationY * new Vector3(0, 0, abstandXZ);
        transform.position = fahrzeug.transform.position - abstandHinterFahrzeug;
        transform.position = new Vector3(transform.position.x, transform.position.y + hoeheY, transform.position.z);
        transform.LookAt(fahrzeug.transform);
    }
}

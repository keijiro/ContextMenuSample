using UnityEngine;

public sealed class Spinner : MonoBehaviour
{
    [field:SerializeField] public float AngularVelocity { get; set; } = 30;

    void Update()
    {
        var delta = AngularVelocity * Time.deltaTime;
        transform.localRotation = Quaternion.AngleAxis(delta, Vector3.up) * transform.localRotation;
    }
}

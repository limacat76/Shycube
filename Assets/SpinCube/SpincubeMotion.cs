using UnityEngine;

public class SpincubeMotion : MonoBehaviour
{

    public bool MustOrbit = false;

    // by Michael House
    // https://gamedev.stackexchange.com/a/62002/92294
    public float OrbitDegrees = 10.0f;

    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle)
    {
        return angle * (point - pivot) + pivot;
    }

    // Update is called once per frame
    void Update()
    {
        if (MustOrbit)
        {
            transform.position = RotatePointAroundPivot(transform.position, transform.parent.position,
                               Quaternion.Euler(0, OrbitDegrees * Time.deltaTime, 0));
        }
    }
}

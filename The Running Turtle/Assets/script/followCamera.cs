
using UnityEngine;

public class followCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    
    private void FixedUpdate()
    {
        transform.position = target.position;
    }

}

using UnityEngine;

[ExecuteAlways]
public class SimpleBillboard : MonoBehaviour
{
    private Transform cameraTransform;
    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    private void LateUpdate()
    {
        Vector3 toCamLocal = cameraTransform.InverseTransformDirection(cameraTransform.position - transform.position);
        toCamLocal.x = 0f;
        toCamLocal = cameraTransform.TransformDirection(toCamLocal.normalized);
        transform.rotation = Quaternion.LookRotation(toCamLocal);
    }
}

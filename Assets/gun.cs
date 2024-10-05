using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public OVRInput.RawButton button;
    public LineRenderer linePrefab;
    public Transform shootingPoint;
    public float maxLineDistance = 5;
    public float lineShowTimer = 0.3f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(button))
        {
            Shoot();
        }
        
        Debug.Log("update");
    }

    public void Shoot()
    {
        Debug.Log("dsssdffsf");
        linePrefab.positionCount = 2;
        linePrefab.SetPosition(0, shootingPoint.position);

        Vector3 endPoint = shootingPoint.position + shootingPoint.forward * maxLineDistance;
        linePrefab.SetPosition(1, endPoint);
        Destroy(linePrefab.gameObject, lineShowTimer);
    }
}

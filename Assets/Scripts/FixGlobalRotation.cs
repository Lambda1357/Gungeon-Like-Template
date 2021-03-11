using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixGlobalRotation : MonoBehaviour
{
    public Vector3 desiredGlobalRotationEuler = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = desiredGlobalRotationEuler;
    }
}

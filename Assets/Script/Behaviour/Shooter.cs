using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private TargetableObject[] targets;
    public Transform rangeAppareance;
    public SphereCollider sphereCollider;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void SetRange(int radius)
    {
        sphereCollider.radius = radius;
        rangeAppareance.localScale = Vector3.one * radius;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

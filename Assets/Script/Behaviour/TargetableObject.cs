using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Collider), typeof(Mortal))]
public class TargetableObject : MonoBehaviour
{
    public Transform targetTransform;
    public Collider targetCollider;
    public Mortal targetMortal;
    // Start is called before the first frame update
    void Awake()
    {
        if(targetTransform == null)
        {
            targetTransform = this.GetComponent<Transform>();
        }       
        
        if(targetCollider == null)
        {
            targetCollider = this.GetComponent<Collider>();
        }        
        
        if(targetMortal == null)
        {
            targetMortal = this.GetComponent<Mortal>();
        }
    }
}

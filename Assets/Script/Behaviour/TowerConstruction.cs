using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TowerConstruction : MonoBehaviour
{
    private int actualCollision;
    public SpriteRenderer spriteRenderer;
    public Renderer rendererVar;
    public Color cantCollideColor = Color.red;
    public Color canCollideColor = Color.green;



    public void Start ()
    {
        rendererVar.material.SetColor("_ColorTextFL", canCollideColor);
        spriteRenderer.color = canCollideColor;
    }
    private void OnTriggerEnter (Collider other)
    {
        if(other.tag != "Unbuildable") {return;}
        actualCollision += 1;
        if(TowerManager.instance.canBuild)
        {
            CantBuild();
        }
    }
    private void OnTriggerExit (Collider other)
    {
        if(other.tag != "Unbuildable") {return;}
        actualCollision -=1;
        if(!TowerManager.instance.canBuild && actualCollision >=0)
        {
            CanBuild();
        }
    }

    private void CantBuild ()
    {
        rendererVar.material.SetColor("_ColorTextFL", cantCollideColor);
        spriteRenderer.color = cantCollideColor;
        TowerManager.instance.canBuild=false;
    }
    private void CanBuild ()
    {
        actualCollision= 0;
        rendererVar.material.SetColor("_ColorTextFL", canCollideColor);
        spriteRenderer.color = canCollideColor;
        TowerManager.instance.canBuild=true;
    }
}

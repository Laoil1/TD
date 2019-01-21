using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Level",menuName="TD/Level",order=3)]
public class LevelData : ScriptableObject 
{
    public Wave[] waves;
    public int dificulty = 0; 

}

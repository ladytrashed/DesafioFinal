using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearWhite : MonoBehaviour
{
    [SerializeField]
    [Range(2, 10)]
    private int damagePoints = 2;
    public int DamagePoints { get { return damagePoints; } }
}

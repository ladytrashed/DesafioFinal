using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]
    [Range(1, 3)]
    private int live = 1;
    public int HP { get { return live; } }
    // Start is called before the first frame update
    public void Healing(int value)
    {
        live += value;
        //DISPARAR EFECTO
        //DISPARAR SONIDO
    }

    public void Damage(int value)
    {
        live -= value;
    }
}

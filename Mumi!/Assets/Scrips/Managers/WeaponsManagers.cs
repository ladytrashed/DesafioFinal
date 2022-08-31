using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsManagers : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;

    [SerializeField] Transform playerHand;

    //2do TDA LISTA
    [SerializeField] List<GameObject> weapomList;
    public List<GameObject> WeaponList { get => WeaponList; set => WeaponList = value; }

    //3er TDA COLA
    private Queue weaponQueue;
    public Queue WeaponQueue { get => weaponQueue; set => weaponQueue = value; }

    //4to Stack
    private Stack weaponStack;
    public Stack WeaponStack { get => weaponStack; set => weaponStack = value; }
    public Dictionary<string, GameObject> WeaponDirectory { get => weaponDirectory; set => weaponDirectory = value; }

    //5to TDA DICCIONARIO
    private Dictionary<string, GameObject> weaponDirectory;

    // Start is called before the first frame update
    void Start()
    {
        /*weapons[0].SetActive(true);
        weapons[0].transform.parent = playerHand;
        weapons[0].transform.localPosition = Vector3.zero;*/
        //DiseableAllWeapons();
        weapomList = new List<GameObject>();
        weaponQueue = new Queue();
        weaponStack = new Stack();
        weaponDirectory = new Dictionary<string, GameObject>();
    }

    void DiseableAllWeapons()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].SetActive(false);
        }
    }

    void EnableAllWeapons()
    {
        foreach (GameObject weapon in WeaponList)
        {
            weapon.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) EnableAllWeapons();
        //INPUT QUEQ
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (IsQueueEmpty())
            {
                GameObject weapon = weaponQueue.Dequeue() as GameObject;
                EquipWeapon(weapon);
            }
        }

        //INPUT STACK
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (IsStackEmpty())
            {
                GameObject weapon = weaponStack.Pop() as GameObject;
                EquipWeapon(weapon);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) EquipWeapon(weaponDirectory["WeaponA"]);
        if (Input.GetKeyDown(KeyCode.Alpha4)) EquipWeapon(weaponDirectory["WeaponB"]);
        if (Input.GetKeyDown(KeyCode.Alpha5)) EquipWeapon(weaponDirectory["WeaponD"]);
        if (Input.GetKeyDown(KeyCode.Alpha6)) EquipWeapon(weaponDirectory["WeaponC"]);
    }

    //M�todo para verificar si la cola est� vac�a.
    private bool IsQueueEmpty()
    {
        return weaponQueue.Count > 0;
    }

    //M�todo para verificar si la pila est� vac�a.
    private bool IsStackEmpty()
    {
        return weaponStack.Count > 0;
    }

    //M�todo que permite equipar el arma al Player
    private void EquipWeapon(GameObject weapon)
    {
        DetachWeapons();
        weapon.SetActive(true);
        weapon.transform.parent = playerHand;
        weapon.transform.localPosition = Vector3.zero;
    }

    //M�todo para remparentar todos los hijos.
    private void DetachWeapons()
    {
        //foreach para recorrer todos los hijos.
        foreach (Transform child in playerHand)
        {
            child.parent = null;
            child.transform.position = new Vector3(Random.Range(0f, 3f), 1f, Random.Range(0f, 3f));
            child.gameObject.SetActive(true);
        }
    }
}

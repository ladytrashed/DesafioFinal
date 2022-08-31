using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    [SerializeField] GameObject boss;
    [SerializeField] GameObject lightPosts;
    [SerializeField] GameObject sun;
    [SerializeField] GameObject moon; 
    [SerializeField] GameObject flashlight;

    [SerializeField] bool isDay, isBoss;
    [SerializeField] Color dayColor, nightColor;
    // Start is called before the first frame update
    

    //AWAKE es un metodo que se ejecuta antes del start
    private void Awake()
    {
        //Activar sol cuando es de d�a
        sun.SetActive(isDay);
        //Activar la luna cuando no es de d�a
        moon.SetActive(!isDay);
        //Activar o desactivar Boss
        boss.SetActive(isBoss);
        //Activar o desactivar Postes de Luz
        lightPosts.SetActive(!isDay);
        //Activar o desactivar Linterna
        flashlight.SetActive(!isDay);
        //Color de fondo de camara segun configuracion del dia.
        //Camera.main.backgroundColor = (isDay) ? dayColor : nightColor;
        RenderSettings.ambientLight = isDay ? Color.white : Color.black;
    }

}

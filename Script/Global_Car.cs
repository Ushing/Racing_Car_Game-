using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Car : MonoBehaviour {

    //1=Red, 2=Blue
    public static int CarType;
    public GameObject MapWindow;
    public void RedCar()
    {
        CarType = 1;
        MapWindow.SetActive(true);
    }
    public void BlueCar()
    {
        CarType = 2;
        MapWindow.SetActive(true);
    }
}

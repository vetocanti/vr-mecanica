//librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//clase -> molde de cocina
public class ActivateTeleportationRay : MonoBehaviour
{
    // atributos -> caracteristicas del molde de cocina
    public GameObject leftTeleportationRay;
    public GameObject rightTeleportationRay;
    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    //metodos

    // Update is called once per frame
    void Update()
    {
        leftTeleportationRay.SetActive(leftActivate.action.ReadValue<float>() > 0.1f);
        rightTeleportationRay.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);
    }
}

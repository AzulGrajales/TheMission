using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parentSalud : MonoBehaviour
{
    public Slider barradesalud2;
    
    public void AsignarSaludMaxima2 (int salud)
    {
        barradesalud2.maxValue = salud;
        barradesalud2.value = salud;
    }

    public void AsignarSalud2 (int salud)
    {
        barradesalud2.value = salud;
    }
}

using UnityEngine;

public class SemaforoEnum : MonoBehaviour
{
    [SerializeField]
    GameObject redlight;
    [SerializeField]
    GameObject greenlight;
    [SerializeField]
    GameObject orangelight;

    float timeInGreen = 15.0f;
    float timeInOrange = 2.0f;
    float timeInRed = 10.0f;
    float contador = 0.0f;
    void Start()
    {
        EncenderLuces(false,false,true);


    }
    void EncenderLuces(bool greenStatus, bool orangeStatus, bool redStatus)
    {
        redlight.SetActive(redStatus);
        greenlight.SetActive(greenStatus);
        orangelight.SetActive(orangeStatus);
    }

    void Update()
    {
        //Verde
        contador += Time.deltaTime;
        if (contador >= timeInRed && redlight.activeSelf == true) {
            EncenderLuces(false, true, false);
            contador = 0.0f;
        }
        //Naranja
        if (contador >= timeInGreen && greenlight.activeSelf == true)
        {
            EncenderLuces(false, false, true);
            contador = 0.0f;
        }
        //Rojo
        if (contador >= timeInOrange && orangelight.activeSelf == true)
        {
            EncenderLuces (true, false, false);
            contador = 0.0f;
        }

        
    }
}


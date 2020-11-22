using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTempearture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Problem 1");
        int temp;
        int tempInCel;
        int tempInFar;

        temp = 0;
        print("Temperature: " + temp);
        tempInCel = ((temp - 32) / 9 ) * 5;
        print("Temperature in celcius: " + tempInCel);
        tempInFar = ((tempInCel * 9) / 5) + 32;
        print("Temperature back in Farenheit: " + tempInFar);
        print("----------------------------------------");

        temp = 32;
        print("Temperature: " + temp);
        tempInCel = ((temp - 32) / 9 ) * 5;
        print("Temperature in celcius: " + tempInCel);
        tempInFar = ((tempInCel * 9) / 5) + 32;
        print("Temperature back in Farenheit: " + tempInFar);
        print("----------------------------------------");

        temp = 212;
        print("Temperature: " + temp);
        tempInCel = ((temp - 32) / 9 ) * 5;
        print("Temperature in celcius: " + tempInCel);
        tempInFar = ((tempInCel * 9) / 5) + 32;
        print("Temperature back in Farenheit: " + tempInFar);
        print("----------------------------------------");

        print("Problem 2");
        float tempFloat;
        float tempInCelFloat;
        float tempInFarFloat;

        tempFloat = 0;
        print("Temperature: " + tempFloat);
        tempInCelFloat = ((tempFloat - 32) / 9 ) * 5;
        print("Temperature in celcius: " + tempInCelFloat);
        tempInFarFloat = ((tempInCelFloat * 9) / 5) + 32;
        print("Temperature back in Farenheit: " + tempInFarFloat);
        print("----------------------------------------");

        print("Problem 3");
        double tempDouble;
        double tempInCelDouble;
        double tempInFarDouble;

        tempDouble = 0;
        print("Temperature: " + tempDouble);
        tempInCelDouble = ((tempDouble - 32) / 9 ) * 5;
        print("Temperature in celcius: " + tempInCelDouble);
        tempInFarDouble = ((tempInCelDouble * 9) / 5) + 32;
        print("Temperature back in Farenheit: " + tempInFarDouble);
        print("----------------------------------------");
    }
}

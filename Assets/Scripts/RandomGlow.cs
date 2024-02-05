using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGlow : MonoBehaviour
{
    private Material material;
    public float changeInterval = 2f; // Time in seconds between color changes

    void Start()
    {
        material = GetComponent<Renderer>().material;
        InvokeRepeating("ChangeColor", 0, changeInterval);
    }

    void ChangeColor()
    {
        Color newColor = Random.ColorHSV(); // Generate a random color
        material.SetColor("_EmissionColor", newColor * Mathf.LinearToGammaSpace(2f)); // Adjust brightness if necessary
    }
}


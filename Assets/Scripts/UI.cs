using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI speedText;
    private Vehicle vehicle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vehicle = FindAnyObjectByType<Vehicle>();
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed: " + Mathf.Round(vehicle.GetCurrentSpeed()).ToString() + "km/h";
    }
}

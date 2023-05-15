using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokeBarrel : MonoBehaviour, IInteractable
{
    public GameObject barrel;
    public GameObject brokenBarrel;

    void Start()
    {
        barrel.SetActive(true);
        brokenBarrel.SetActive(false);
    }

    public string GetDescription()
    {
        return "Нажмите [Е], чтобы прогрызть дырку";
    }

    public void Interact()
    {
        barrel.SetActive(false);
        brokenBarrel.SetActive(true);
    }
}

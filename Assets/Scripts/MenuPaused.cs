using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPaused : MonoBehaviour
{
    public GameObject menuPaused;
    public Crosshair crosshair;

    [SerializeField] KeyCode keyMenuPaused;
    bool isMenuPaused = false;

    private void Start()
    {
        menuPaused.SetActive(false);
    }

    private void Update()
    {
        ActiveMenu();
    }

    void ActiveMenu()
    {
        if (Input.GetKeyDown(keyMenuPaused))
        {
            isMenuPaused = !isMenuPaused;
        }

        

        if (isMenuPaused)
        {
            menuPaused.SetActive(true);
            crosshair.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            menuPaused.SetActive(false);
            crosshair.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }
    }

    public void MenuPausedContinue()
    {
        isMenuPaused = false;
    }

    public void MenuPausedSettings()
    {
        Debug.Log("Настройки");
    }

    public void MenuPausedMainMenu()
    {
        Debug.Log("Главное меню");
    }
}

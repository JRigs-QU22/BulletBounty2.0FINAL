using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManageGame : MonoBehaviour
{
    // Elena wrote this to manage the opening screens of the game. This creates screen groups and
    // makes them visible as needed

    [SerializeField]  // this allows a var to appear in the inspector even though it is private
    private CanvasGroup GenStoreMenu;

    [SerializeField]
    private CanvasGroup SaloonMenu;

    [SerializeField]
    private CanvasGroup SheriffMenu;




    void Awake() // when game starts, make title screen active and turn off the input name and instruct screens
    {
        SaloonMenu.alpha = 0f;
        SaloonMenu.interactable = false;
        SaloonMenu.blocksRaycasts = false;

        GenStoreMenu.alpha = 0f;
        GenStoreMenu.interactable = false;
        GenStoreMenu.blocksRaycasts = false;

        SheriffMenu.alpha = 0f;
        SheriffMenu.interactable = false;
        SheriffMenu.blocksRaycasts = false;
    }

    public void LoadInputGenStore() // when this function is called, turn off title screen and turn on input
    {

        GenStoreMenu.alpha = 1f;
        GenStoreMenu.interactable = true;
        GenStoreMenu.blocksRaycasts = true;

        SaloonMenu.alpha = 0f;
        SaloonMenu.interactable = false;
        SaloonMenu.blocksRaycasts = false;

        SheriffMenu.alpha = 0f;
        SheriffMenu.interactable = false;
        SheriffMenu.blocksRaycasts = false;

        Time.timeScale = 0;

    }



    public void LoadInputSaloon() //when this function is called, turn off input screen and turn on instruct
    {

        SaloonMenu.alpha = 1f;
        SaloonMenu.interactable = true;
        SaloonMenu.blocksRaycasts = true;

        GenStoreMenu.alpha = 0f;
        GenStoreMenu.interactable = false;
        GenStoreMenu.blocksRaycasts = false;

        SheriffMenu.alpha = 0f;
        SheriffMenu.interactable = false;
        SheriffMenu.blocksRaycasts = false;

        Time.timeScale = 0;
    }

    public void LoadInputSheriff() //when this function is called, turn off input screen and turn on instruct
    {

        SaloonMenu.alpha = 0f;
        SaloonMenu.interactable = false;
        SaloonMenu.blocksRaycasts = false;

        GenStoreMenu.alpha = 0f;
        GenStoreMenu.interactable = false;
        GenStoreMenu.blocksRaycasts = false;

        SheriffMenu.alpha = 1f;
        SheriffMenu.interactable = true;
        SheriffMenu.blocksRaycasts = true;

        Time.timeScale = 0;

    }

    public void ExitMenus() //when this function is called, turn off input screen and turn on instruct
    {

        SaloonMenu.alpha = 0f;
        SaloonMenu.interactable = false;
        SaloonMenu.blocksRaycasts = false;

        GenStoreMenu.alpha = 0f;
        GenStoreMenu.interactable = false;
        GenStoreMenu.blocksRaycasts = false;

        SheriffMenu.alpha = 0f;
        SheriffMenu.interactable = false;
        SheriffMenu.blocksRaycasts = false;

        Time.timeScale = 1;

    }



}

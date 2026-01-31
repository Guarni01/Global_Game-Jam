using UnityEngine;

public class GameController : MonoSingleton<GameController>
{
    public GameObject Hub;


    public void StartGame()
    {
        Hub.SetActive(true);


    }

    public void OptionsGame()
    {
        Hub.SetActive(true);


    }
}

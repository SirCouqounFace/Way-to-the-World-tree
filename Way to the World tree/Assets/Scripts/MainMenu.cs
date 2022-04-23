using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField codeInput;
    
    public void StartGame()
    {
        SceneManager.LoadScene("Caves");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void CodeStart()
    {
        string code = codeInput.text;

        code = code.ToUpper();

        if (code == "DFLD")
        {
            SceneManager.LoadScene("Defiled Forest");
        }
        else if (code == "CORE")
        {
            SceneManager.LoadScene("Core Forest");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ResetToMenu", 30f);
    }

    private void ResetToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

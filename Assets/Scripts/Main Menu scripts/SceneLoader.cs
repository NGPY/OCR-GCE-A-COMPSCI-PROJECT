using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public static void LoadStartSimMenu()
    {
        SceneManager.LoadScene(1);
    }
    public static void LoadOptionsMenu()
    {
        SceneManager.LoadScene(2);
    }
    public static void LoadLearnMenu()
    {
        SceneManager.LoadScene(3);
    }
    public static void LoadGraphicsMenu()
    {
        SceneManager.LoadScene(4);
    }
    public static void LoadAccessibilityMenu()
    {
        SceneManager.LoadScene(5);
    }
    public static void LoadKeybindsMenu()
    {
        SceneManager.LoadScene(6);
    }
    public static void ExitProgram()
    {
        Application.Quit();
    }
}

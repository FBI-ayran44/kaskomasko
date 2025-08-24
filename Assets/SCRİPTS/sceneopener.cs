using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneopener : MonoBehaviour
{
    public void levelOpen()
    {
        SceneManager.LoadScene(1);
    }
    public void emek()
    {
        SceneManager.LoadScene(2);
    }
}

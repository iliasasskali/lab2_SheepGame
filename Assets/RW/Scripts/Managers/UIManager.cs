using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Text sheepSavedText;
    public Text sheepDroppedText;
    public GameObject gameOverWindow;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Get sheeps saved
    public void UpdateSheepSaved() 
    {
        sheepSavedText.text = GameStateManager.Instance.sheepSaved.ToString();
    }

    // Get sheeps dropped
    public void UpdateSheepDropped()
    {
        sheepDroppedText.text = GameStateManager.Instance.sheepDropped.ToString();
    }
    // Activate Game Over Window
    public void ShowGameOverWindow()
    {
        gameOverWindow.SetActive(true);
    }


}

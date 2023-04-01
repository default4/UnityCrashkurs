using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debug_ausgabe : MonoBehaviour
{
    public Button button_to_debug;
	public GameObject model;	
   

    // Wird aufgerufen, wenn das Skript geladen wird
    void Start()
    {
        // Fügt dem Button einen Click-Event-Handler hinzu
        button_to_debug.onClick.AddListener(HandleClick);
    }

    // Wird aufgerufen, wenn der Button geklickt wird
    void HandleClick()
    {
		Debug.Log("Button was clicked!");
        // Verdoppelt die Skalierung des Modells
        model.transform.localScale *= 2.0f;
    }
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCharacter : MonoBehaviour
{
    void Start()
    {
        // Verändere Position, Rotation und Skalierung des GameObjects
        transform.position = new Vector3(0f, 2f, 0f);
        transform.rotation = Quaternion.Euler(0f, 45f, 0f);
        transform.localScale = new Vector3(2f, 2f, 2f);
    }

    void Update()
    {
        
    }
}

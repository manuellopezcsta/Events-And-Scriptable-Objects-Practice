using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class ChangeBallColour : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        EventManager.current.changeBallColorEvent += ChangeColor; 
    }

    void ChangeColor()
    {
        Color randomColor = UnityEngine.Random.ColorHSV();
        spriteRenderer.color = randomColor;
    }

    // Importante con eventos desubscribirlos para evitar errores una vez que se usaron.
    void OnDisable()
    {
        EventManager.current.changeBallColorEvent -= ChangeColor;
    }
}

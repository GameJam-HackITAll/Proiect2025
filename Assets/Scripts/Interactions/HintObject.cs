using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using JetBrains.Annotations;

public class HintObject : InteractableObject
{
    public Image info;

    public override void Interact()
    {
        info.gameObject.SetActive(true);
    }
}

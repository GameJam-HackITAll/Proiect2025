using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using JetBrains.Annotations;

public class DoorObject : InteractableObject
{
    public bool isLocked = true;
    public Sprite locked;
    public Sprite canUnlock;
    public Sprite unlocked;
    public Image blackScreenPanel;
    public int xPos, yPos;
    public float transitionTime = 1.5f; 
    public float fadeTime = 1.5f;

    public override void Interact()
    {
        if(!isLocked)
        {
            highlight = unlocked;
            GetComponent<SpriteRenderer>().sprite = highlight;
            StartCoroutine(FadeIn(blackScreenPanel));
        }
    }

    public void UnlockDoor()
    {
        highlight = canUnlock;
        isLocked = false;
    }

    IEnumerator FadeIn(Image screen)
    {
        screen.gameObject.SetActive(true); 

        Color panelColor = screen.color;
        panelColor.a = 0f;
        screen.color = panelColor;

        float elapsedTime = 0f;

        while (elapsedTime < fadeTime)
        {
            panelColor.a = Mathf.Lerp(0f, 1f, elapsedTime / fadeTime);
            screen.color = panelColor;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        panelColor.a = 1f;
        screen.color = panelColor;

        Camera.main.transform.position = new Vector3(xPos, yPos, Camera.main.transform.position.z);
        StartCoroutine(FadeOut(screen));
    }

    IEnumerator FadeOut(Image screen)
    {
        screen.gameObject.SetActive(true);

        Color panelColor = screen.color;
        panelColor.a = 1f;
        screen.color = panelColor;

        float elapsedTime = 0f;

        while (elapsedTime < fadeTime)
        {
            panelColor.a = Mathf.Lerp(1f, 0f, elapsedTime / fadeTime);
            screen.color = panelColor;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        panelColor.a = 0f;
        screen.color = panelColor;
    }

}

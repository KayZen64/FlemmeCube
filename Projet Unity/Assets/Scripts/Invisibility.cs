using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : MonoBehaviour
{
    public InputMaster controls;

    public float invTime = 5.0f;
    public float invCooldown = 5.0f;
    bool isInvEnabled = false;
    bool isCooldown = false;
    public Texture2D invTexture;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private Sprite oldSprite;

    public AptitudesUI aptitudesUIComponent;


    public void StartInvisibility() {
        if(!isInvEnabled && !isCooldown) {
            Debug.Log("startinvisibility");
            isInvEnabled = true;
            aptitudesUIComponent.SquareAptUIOff();   
            oldSprite = spriteRenderer.sprite;
            spriteRenderer.sprite = newSprite;
            StartCoroutine(InvCoroutine());
        }
        else {
            Debug.Log("Invisibilité déjà activée");
        }
    }

    IEnumerator InvCoroutine() {
        Debug.Log("Coroutine démarrée " + Time.time);
        yield return new WaitForSeconds(invTime);
        spriteRenderer.sprite = oldSprite; 
        isInvEnabled = false;
        Debug.Log("Coroutine finie " + Time.time);
        isCooldown = true;

        yield return new WaitForSeconds(invCooldown);
        isCooldown = false;
        aptitudesUIComponent.SquareAptUIOn();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : MonoBehaviour
{
    public InputMaster controls;

    public float invTime = 5.0f;
    public float invCooldown = 5.0f;
    bool isInvEnabled;
    public Texture2D invTexture;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private Sprite oldSprite;


    public void StartInvisibility() {
        if(!isInvEnabled) {
            Debug.Log("startinvisibility");
            isInvEnabled = true;
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
        Debug.Log("Coroutine finie " + Time.time);

        yield return new WaitForSeconds(invCooldown);
        isInvEnabled = false;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private int cardValue;
    [SerializeField] private bool isFlipped = false;
    [SerializeField] private bool canFlip = true;


    [SerializeField] private Sprite cardBack;
    [SerializeField] private Sprite cardFront;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FlipCard()
    {
        if (canFlip && !isFlipped)
        {
            isFlipped = true;
            animator.SetTrigger("Flip");
            // Flip Sound
        }
    }
    public void SetCardFront()
    {
        spriteRenderer.sprite = cardFront;
    }

    public void SetCardBack()
    {
        spriteRenderer.sprite = cardBack;
    }

}

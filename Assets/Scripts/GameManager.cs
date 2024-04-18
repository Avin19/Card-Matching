using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject pfCard;
    [SerializeField] private RectTransform cardsParent;

    [SerializeField] private Sprite[] cardFrontSprites;
    [SerializeField] private TextMeshProUGUI scoreText;

    private List<Card> cards = new List<Card>();

    private int score = 0;

    private void Start()
    {
        GenerateCards();
        // UpdateScore();
    }

    private void UpdateScore()
    {
    }

    private void GenerateCards()
    {
        int numRows = 4;
        int numCols = 4;

        float cardWidth = cardsParent.rect.width / numCols;
        float cardHeight = cardsParent.rect.height / numRows;


        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                GameObject cardGo = Instantiate(pfCard, cardsParent.transform);
                RectTransform cardTransfrom = cardGo.GetComponent<RectTransform>();

                cardTransfrom.localPosition = new Vector3(j * cardWidth, -i * cardHeight, 0);
                cardTransfrom.sizeDelta = new Vector2(cardWidth, cardHeight);

                // Add Card component and set properties
                Card card = cardGo.GetComponent<Card>();
                int randomIndex = Random.Range(0, cardFrontSprites.Length);
                card.SetCardValue(randomIndex);
                card.SetCardFront(cardFrontSprites[randomIndex]);
                cards.Add(card);
            }
        }

    }
}
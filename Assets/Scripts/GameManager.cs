using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject pfCard;
    [SerializeField] private Transform cardsParent;

    [SerializeField] private Sprite[] cardFrontSprites;
    [SerializeField] private TextMeshProUGUI scoreText;
}
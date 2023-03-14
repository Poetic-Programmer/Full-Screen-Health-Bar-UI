using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private List<Sprite> HealthSprites = new List<Sprite>();
    private Image CurrentHealthImage;

    private void Awake()
    {
        CurrentHealthImage = GetComponentInChildren<Image>();
    }
    public void SetHealthFromPercentage(float healthPercentage)
    {
        var totalImageCount = HealthSprites.Count-1;
        var imageIndex = (healthPercentage / 100) * (totalImageCount);
        imageIndex = Mathf.Ceil(totalImageCount - imageIndex);
        CurrentHealthImage.sprite = HealthSprites[(int)imageIndex];
    }
}
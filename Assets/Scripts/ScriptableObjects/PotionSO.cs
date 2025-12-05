using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Yeni Iksir", menuName = "CadiOyunu/Iksir Tarifi (Potion)")]
public class PotionSO : ScriptableObject
{
    [Header("Ýksir Kimliði")]
    public string potionName;     // Ýksir adý (Örn: Uyku Ýksiri)
    public Sprite potionIcon;     // Þiþelenmiþ hali

    [Header("Tarif")]
    public List<IngredientSO> requiredIngredients; // Gereken malzemeler listesi
    public float baseCookTime;    // Ýdeal piþme süresi (saniye)

    [Header("Teþhis Bilgileri")]
    // Müþterinin söyleyebileceði, bu iksirin çözdüðü belirtiler
    public List<string> symptoms;

    [Header("Ödül")]
    public int rewardMoney;       // Satýþ fiyatý
}
using UnityEngine;

[CreateAssetMenu(fileName = "Yeni Malzeme", menuName = "CadiOyunu/Malzeme (Ingredient)")]
public class IngredientSO : ScriptableObject
{
    [Header("Temel Bilgiler")]
    public string ingredientName; // Malzemenin adý
    public IngredientType type;   // Türü (Ot, Mineral vs.)

    [Header("Görsel & Ekonomi")]
    public Sprite icon;           // Envanterde görünecek ikon
    public int baseCost;          // Marketteki fiyatý

    [TextArea]
    public string description;    // Kitapta yazacak kýsa bilgi
}
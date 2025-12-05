using UnityEngine;

public enum IngredientType
{
    Bitki,      // Otlar, çiçekler
    Mineral,    // Taþlar, tozlar
    Organik,    // Böcek parçalarý, gözler vb.
    Sivi        // Þiþelenmiþ sular, yaðlar
}

public enum PotionEffectType
{
    Iyilesme,
    Guclendirme,
    Zehir,
    Uyku,
    Ask
}

[CreateAssetMenu(fileName = "IngredientSO", menuName = "Scriptable Objects/IngredientSO")]
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

using UnityEngine;

[CreateAssetMenu(fileName = "Yeni Yakit", menuName = "CadiOyunu/Yakit (Fuel)")]
public class FuelSO : ScriptableObject
{
    [Header("Yakýt Özellikleri")]
    public string fuelName;       // Odun adý (Meþe, Çam vb.)

    [Tooltip("Saniye cinsinden yanma süresi")]
    public float burnDuration;    // Ne kadar süre yanacaðý (örn: 10 saniye)

    [Tooltip("Piþirme hýzýný kaç katýna çýkaracaðý (1 standart, 2 hýzlý)")]
    public float heatMultiplier;  // Isý çarpaný

    public int price;             // Market fiyatý
    public Sprite icon;           // Görseli
}
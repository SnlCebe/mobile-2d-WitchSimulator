using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Yeni Musteri", menuName = "CadiOyunu/Musteri Profili")]
public class CustomerProfileSO : ScriptableObject
{
    public string customerName;
    public Sprite characterVisual; // Karakterin çizimi/sprite'ý

    [Header("Diyaloglar")]
    [TextArea]
    public List<string> possibleDialogues; // "Midem bulanýyor", "Baþým dönüyor" gibi þikayet cümleleri havuzu.
}
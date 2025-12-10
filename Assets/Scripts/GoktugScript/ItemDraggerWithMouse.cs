using UnityEngine;

public class ItemDraggerWithMouse : MonoBehaviour
{
    private Vector3 offset; //Fare itemi aldýðýnda otomatik obje merkezine aktarýlmasýn diye offset isimli bir vector3 objesi ürettik.
    private Rigidbody2D rigidbody2d;
    private RigidbodyType2D initialBodyType;
    

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        
        if (rigidbody2d == null)
        {
            // Eðer Rigidbody yoksa, sürükleme çalýþmaz. Konsolda hata mesajý verilir.
            Debug.LogError(gameObject.name + " objesinde Rigidbody2D bulunamadi. ItemDragger calisamaz.", this);
            enabled = false;
            return;
        }

        // BAÞLANGIÇ TÝPÝNÝ KAYDET: Býrakýnca bu tipe geri dönecek.
        initialBodyType = rigidbody2d.bodyType;
        
    }

    private void OnMouseDown() //Týklama Aný
    {
        //Fare pozisyonunu alýp offseti hesaplama
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);  //Bu kýsýmda ekran koordinatlarý ile sahne koordinatlarýný eþitledik 
        rigidbody2d.bodyType = RigidbodyType2D.Kinematic; //Bu kýsýmda da itemi aldýðýmýzda kinematic yaparak yerçekimi gibi dýþ etkenlerden etkilenmemesini saðladým
    }
    private void OnMouseDrag() //Sürükleme Aný
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Fareyi takip ettiriyoruz
        newPos.z = 0f; //Z eksenini koruyoruz

        transform.position = newPos + offset; // +offset eklememizin sebebi offseti oluþturmamýzdaki amaç ile ayný merkeze mouse gelmesin diye direk
    }
    private void OnMouseUp()
    {
        rigidbody2d.bodyType = initialBodyType; //burda da mouseyi býrakýnca itemimizin tekrardan yerçekimi gibi etkenlerden etkilenebilmesini istedik.
    }
}

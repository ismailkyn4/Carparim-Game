using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform gun;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletPlace;
    float angle;
    float rotationSpeed=5f;
    void Update()
    {

        RotateChange();
    }
    void RotateChange()
    {
        if (Input.GetMouseButtonDown(0)) //farenin sol tu�una bas�ld���nda silah�n d�nmesini sa�l�yoruz.
        {
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gun.transform.position; //mouse'ye t�klad���m andaki pozisyondan silah�n pozisyonunu ��kart�yoruz.
            angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f; //buldu�umuz y�n�n direction y sini x'ine b�l. ��kan sonu� radyan �l��d�r.Oy�zden dereceye d�n��t�rd�k.
                                                                                 //90f yaparak y�ndeki hatay� ��zd�k.
        }


        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        gun.transform.rotation = Quaternion.Slerp(gun.transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
    void Shoot() //ate� etme fonksiyonu
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletPlace.position, bulletPlace.rotation) as GameObject;//mermi mermiyerinin pozisyonunda ayn� rotate y�n�yle ��kacak. Ve gameobjeye d�n��t�r�lecek.
    }
}

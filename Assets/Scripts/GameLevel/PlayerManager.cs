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
        if (Input.GetMouseButtonDown(0)) //farenin sol tuþuna basýldýðýnda silahýn dönmesini saðlýyoruz.
        {
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gun.transform.position; //mouse'ye týkladýðým andaki pozisyondan silahýn pozisyonunu çýkartýyoruz.
            angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f; //bulduðumuz yönün direction y sini x'ine böl. Çýkan sonuç radyan ölçüdür.Oyüzden dereceye dönüþtürdük.
                                                                                 //90f yaparak yöndeki hatayý çözdük.
        }


        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        gun.transform.rotation = Quaternion.Slerp(gun.transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
    void Shoot() //ateþ etme fonksiyonu
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletPlace.position, bulletPlace.rotation) as GameObject;//mermi mermiyerinin pozisyonunda ayný rotate yönüyle çýkacak. Ve gameobjeye dönüþtürülecek.
    }
}

# Pratik - Abstraction
Düşünün ki bir şirketin çalışanlarını temsil eden bir program yazıyorsunuz.

Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır

Ancak her çalışanın görevi (pozisyonu) farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).

Gorev metodunu çağırdığımızda her çalışan kendi yaptığı işi konsol ekranında söyleyecek.

Örneğin

Hasan Çıldırmış şirketin Proje yönetcisi, kendisi üzerinden Gorev() abstract metodu çağırıldığında konsol ekranında

" Proje yöneticisi olarak çalışıyorum. " yazdırılmasını istiyoruz.


# Kod Açıklaması:
* Calisan Sınıfı: Tüm çalışanların ortak özelliklerini (Ad, Soyad, Departman) ve soyut bir Gorev metodunu içerir. Gorev metodu, her bir türetilmiş sınıfta farklı şekilde uygulanacaktır.
* Türetilmiş Sınıflar: MagazaYoneticisi, ProjeYoneticisi ve SatisTemsilcisi sınıfları, Calisan sınıfından türetilir ve Gorev metodunu kendi görevlerine göre override eder.
* Polimorfizm: Gorev metodu, farklı türetilmiş sınıflarda farklı davranış sergiler. Bu sayede, aynı metodu çağırırken farklı sonuçlar elde edilir.
* Örnek Kullanım: Farklı çalışan türlerinden nesneler oluşturulur ve Gorev metodu çağrılarak çalışanların görevleri ekrana yazdırılır.

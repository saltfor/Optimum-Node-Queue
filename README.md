# Optimum-Node-Queue
Toplam düğüm puanlarının minumum olduğu sırayı bulan yazılım.

n adet düğümden oluşan bir sistemde, düğümlerin değerini önceden hazırlanmış data.txt dosyasından okuyarak deger isimli tek boyutlu diziye aktaran, düğümlerin sırasını ve değerini kullanarak HER DÜĞÜM SIRASI PUANINI fonksiyonda hesaplayan, düğümlerin İLK Mevcut Düğüm Sırasını rastgele belirleyip aşağıda belirtilen adımları 500 kere tekrarlayarak EN DÜŞÜK TOPLAM PUANA sahip düğüm sırasını TextBox’a, bu sıranın puanını Label’a yazdıran C# yazılımı.

Adım 1. Mevcut Düğüm Sırasından rastgele 2 düğümü seç ve onları yer değiştirerek Yeni Düğüm Sırasını bul.
Adım 2. Yeni Düğüm Sırasının puanını hesapla.
Adım 3. Mevcut Düğüm Sırasının puanı ile Yeni Düğüm Sırasının puanını karşılaştır. 
•	Eğer Mevcut Düğüm Sırasının puanı daha düşük ise Mevcut Düğüm Sırasını değiştirmeyerek Adım 1’e dön. 
•	Eğer Yeni Düğüm Sırasının puanı daha düşük ise Yeni Düğüm Sırasını Mevcut Düğüm Sırası olarak atayarak Adım 1’e dön.    

NOT 1. Bir düğüm sırası puanının hesaplanması: Bunun için öncelikle o sıradaki her düğümün puanı hesaplanmalı. Bir düğümün sırası kendisi ve o sıradaki kendisinden önce gelen düğümlerin değeri toplamıdır. Bütün düğümlerin puanı hesaplandıktan sonra sıranın puanı bütün düğümlerin puanları toplamı ile hesaplanır. 

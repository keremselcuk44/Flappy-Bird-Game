# Flappy Bird Oyunu - C# Windows Forms
## Proje Hakkında
Bu proje, klasik Flappy Bird oyununun C# Windows Forms kullanılarak geliştirilmiş bir versiyonudur. Oyuncu, space tuşuna basarak kuşu kontrol eder ve borular arasından geçerek puan toplar.

Özellikler
🎮 Oyun Mekanikleri
Kuş Kontrolü: Space tuşu ile kuşu zıplatma

Yerçekimi Sistemi: Kuş sürekli aşağı doğru düşer

Borular: Rastgele yüksekliklerde borular arasından geçiş

Zemin Hareketi: Sürekli hareket eden zemin efekti

⚡ Zorluk Sistemi
Kademeli Zorluk: Skor arttıkça hız ve yerçekimi artar

Seviyeler:

0-5 skor: Normal hız

6-10 skor: Orta hız

11-20 skor: Yüksek hız

20+ skor: Çok yüksek hız

🏆 Skor Sistemi
Anlık Skor: Mevcut oyun skoru

En Yüksek Skor: Tüm zamanların en iyi skoru

Otomatik Kayıt: En yüksek skor otomatik olarak kaydedilir

🎯 Oyun Bitiş ve Yeniden Başlatma
Çarpışma Tespiti: Borular, zemin ve ekran dışı kontrolü

Oyun Bitti Paneli: Modern oyun bitti ekranı

Yeniden Başlatma: Yeniden başlat butonu ile hızlı yeniden başlatma

Çıkış Seçeneği: Çıkış butonu ile oyundan çıkış

Teknik Özellikler
🛠️ Geliştirme Ortamı
Platform: Windows Forms

Dil: C#

Framework: .NET Framework

🎨 Kullanıcı Arayüzü
Duyarlı Tasarım: Merkezi oyun bitti paneli

Modern Butonlar: Üzerine gelince efektli butonlar

Renk Şeması:

Yeniden Başlat Butonu: Yeşil tonları

Çıkış Butonu: Kırmızı tonları

Arkaplan: Yarı saydam siyah panel

⚙️ Kontroller
Klavye Girdisi: Space tuşu ile kontrol

Fare Girdisi: Buton tıklamaları

Odağı Yönetimi: Klavye odak yönetimi

Kurulum ve Çalıştırma
Gereksinimler
Visual Studio (2019 veya üzeri)

.NET Framework 4.5 veya üzeri

Çalıştırma Adımları
Projeyi klonlayın veya indirin

Visual Studio'da açın

Gerekli NuGet paketlerinin yüklü olduğundan emin olun

Projeyi derleyin ve çalıştırın

Oyun Kontrolleri
Tuş	Aksiyon
Space	Kuşu zıplat
Yeniden Başlat Butonu	Oyunu yeniden başlat
Çıkış Butonu	Oyundan çık
Oyun Kuralları
Borulara veya zemine çarpmadan mümkün olduğunca ilerle

Her boru setinden geçişte 1 puan kazan

Yüksek skoru geçmeye çalış

Zorluk seviyesi arttıkça dikkatli ol

Geliştirici Notları
Kod Yapısı
OOP Prensipleri: Sınıf tabanlı yapı

Olay Yönetimi: Zamanlayıcı ve klavye olayları

Çarpışma Tespiti: Bounds.IntersectsWith metodu

Genişletilebilirlik
Yeni boru setleri eklenebilir

Farklı zorluk seviyeleri tanımlanabilir

Görsel iyileştirmeler yapılabilir

Sınıf Yapısı
Ana Form (play.cs)
Özellikler: Oyun değişkenleri (hız, yerçekimi, skor)

Metodlar: Oyun mantığı, çarpışma tespiti, arayüz yönetimi

Olaylar: Klavye işleyicileri, zamanlayıcı tik olayları

Oyun Bileşenleri
Borular: Sürekli oyun için çoklu boru setleri

Kuş: Oyuncu kontrollü karakter

Zemin: Hareketli arkaplan elemanı

Arayüz Elemanları: Skor görüntüsü, oyun bitti paneli

Lisans
Bu proje eğitim amaçlı geliştirilmiştir. Özgün Flappy Bird oyunu .Gears şirketine aittir.

Katkıda Bulunma
Projeyi çatallayın

Özellik dalı oluşturun (git checkout -b feature/harikaOzellik)

Değişikliklerinizi kaydedin (git commit -m 'Harika bir özellik ekle')

Dalı push edin (git push origin feature/harikaOzellik)

Pull Request oluşturun

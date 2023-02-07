# Unity'de ışıklar

Light (ışık) aslında bir gameobject'tir ve Light Componentine sahiptirler.
Light Componenti ile ışığımızın değerlerini değiştirebiliriz.

2 Tür ışıklandıma sistemi vardır.
	1. Real Time Lighting Gerçek zamanlı olarak sahnemizi aydınlatır.
	2. Bake Lighting - Önceden hesaplanmış ışıklandıma sistemi
	
Window -> Rendering -> Lighting menüsü altında bulunan panel sayesinde
ışıklandıma ile ilgili birçok ayarı bulabiliriz.
Bu alanı, inspector alanının yanına çekelim. 

## Işık Tipleri
### Directional Light
Bakış yönü neresi ise o taraftan bir güneş gibi aydınlatma gerçekleştirir.
Pozisyon olarak sahne ışıklandımasına hiçbir etkisi yoktur ancak,
Rotasyon olarak ışığın gelme açısını değiştirdiğimizden, gölge yönleri değişecektir.
		
Birden fazla kullanılabilir.
Özellikle büyük haritalarda fazladan Directional Light eklemek, daha doğal bir ışık yaymak için
güzel bir seçenek olacaktır.
	
  - intensity: Işık parlaklık gücü
  - Shadow Type: Gölge yapısı
		Gölgeler ekran kartını yük bindirir. 
		Soft Shadow daha az kaynak tüketirken, Hard Shadow daha fazla kaynağa ihtiyaç duyar.
  - Point Light: Noktasal Işık Kaynağı
		Sahnede belli bir noktadan, ışığı her yöne eşit olarak dağıtır.
		Bir çember gibi alan olarak yayım yapar.
		Range: Menzil demektir.
			
	>	Directional Light ile farkları
			Kendisine ait bir menzili vardır
			Pozisyonu önemlidir.
			
### Spot Light
Sahnede bir noktada bulunan ve koni şeklinde ışık yayan bir ışık türüdür.
Yine Light Componenti kullanılarak değerlerini değiştirebiliriz
			
			
> NOT: Yukarıdaki 3 tip ışık türümüzde Real Team Lighting olarak çalışmaktadır.
	Ancak Area Light ise Bake Lighting olarak çalışmaktadır. Önceden hesaplama gerektirmektedir.
	Bu kısımda önceden hesaplama işlemlerinide görelim.
	
### Area Light
Bölgesel alan ışığı
			
Sahneden bir dikdörtgen tarafından tanımlanan ve yüzey alanını nasıl ayarlarsak o alanda
ışık yayan bir ışık türüdür. Sadece dikdörtgen olarak değil, disk olarakda kullanabiliriz.
			
> Bake Light'ları sadece STATIC OBEJELER ile kullanabiliriz.
				
- Static Obejeler: Sabit obejeler olarak daha önce öğrenmiştik.
Sabit obejeler oyun motoru tarafından önceden hesaplanırlar ve hareket etmeyecekleri için
bir kez hesaplanarak değerlendirilirler. Dolayısıyla static obejeler PERFORMANS'ı olumlu yönde
etkilerler. Daha performanslı çalışırlar ve sahnemize daha çabuk yüklenip, oluşurlar.
				
> Baked Global Illumination seçeneğinin aktif olduğundan emin olun.
- Progressive CPU: İşlemci Tabanlı hesaplama yaparlar. CPU'lar ışık hesaplama konusunda yavaştırlar.
-	Progressive GPU: Grafik Kartı Tabanlı. GPU'lar ışık hesaplama konusunda hızlıdırlar.
		
İlgili değişiklikleri yaptıktan sonra **"New Lighting Settings"** diyerek kaydediyoruz ve Asset
kısmına yeni bir Işık Obejesinin oluştuğunu görebilirisiniz.
		
-	Auto Generate: Işık hesaplamasını canlı olarak uygular. Ancak, büyük haritalarda bu işlem uzun
süreceği için, geliştirme aşamasında performans kaybına neden olabileceği gibi, çalışma süremizide arttıracaktır.
Bunun yerine, bir değişiklik yapıldıktan sonra **"Generate Lighting"** seçeneği ile elle yapmakda fayda vardır.
			

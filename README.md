
<h1 align="center">
  <br>
  SignalR Restoran Yönetim & Rezervasyon Projesi
  <br>
</h1>

<h4 align="center">Asp.Net Core Api ve SignalR kullanılarak geliştirilen Restoran Projesi</h4>

<p align="center">
  <a href="#hakkında">Hakkında</a> •
  <a href="#nasıl-kullanılır">Nasıl Kullanılır</a> •
  <a href="#görseller">Görseller</a> •
</p>


## Hakkında
.Net Core 6.0, .Net Core Api, SignalR, N Tiear Architecture, Repository Design Pattern, MSSQL, Entity Framework Core, LINQ, HTML, CSS, Bootstrap, Javascript, Ajax, Dto Layer, Rezervasyon İşlemleri, Mail Gönderme İşlemleri, QRCode İşlemleri, Real-Time Mesajlaşma, Real-Time İstatistik, Real-Time Bildirim, Swagger

Projenin temel amacı, restoran işletmelerinin yönetimini modernize ederek, kullanıcıların web sitesi arayüzü üzerinden restoran hakkında bilgi alabilmelerini sağlamak ve rezervasyon yapmalarına imkan tanımaktır. Ayrıca, kullanıcılar admin paneline öneri, talep, şikayet gibi konularda mesaj gönderebilirler. Bu mesajlar, SignalR teknolojisi kullanılarak anlık olarak dashboard üzerinde görüntülenebilir. Admin kullanıcısı, rezervasyon mesajlarını ve bildirimleri anlık olarak takip edebilir, böylece hızlı ve etkili bir iletişim sağlanır.

Ayrıca, restoran içerisinde hangi masaların dolu ve boş olduğu da sistem üzerinden görülebilir. Bu özellik, restoranın işleyişini daha verimli hale getirir ve masaların daha etkin bir şekilde yönetilmesini sağlar. Admin panelinde bu bilgilerin anlık olarak güncellendiği ve görsel olarak kolayca takip edilebildiği bir dashboard bulunmaktadır.

## Nasıl Kullanılır

```bash
# Projeyi klonlayın
$ git clone https://github.com/vuralsayan/SignalRestaurant

# DbContext sınıfınında bulunan connection string'i düzenleyin
$ .\SignalRestaurant\SignalR.DataAccessLayer\Concrete\SignalRContext.cs

# Migration oluşturup veritabanını lokalinizde çalıştırın
$ add-migration & update database

# Önce api projesini sonra UI projesini çalıştırıp kullanabilirsiniz
```
---

## Görseller


 
 


> [vuralsayan.com](https://www.vuralsayan.com) &nbsp;&middot;&nbsp;
> GitHub [@vuralsayan](https://github.com/vuralsayan) &nbsp;&middot;&nbsp;
> LinkedIn [@Vural Sayan](https://www.linkedin.com/in/vural-sayan-79326a171/)


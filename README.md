# AR → VR Ground Plane to Room-Scale Project

Proyek ini adalah sistem yang menghubungkan Ground Plane AR (placement objek) dengan Room-Scale VR environment. Pengguna dapat meletakkan objek di dunia nyata, menekan objek tersebut, lalu masuk ke mode VR untuk eksplorasi ruangan 3D.

## 🚀 Fitur Utama
- AR Ground Plane (ARFoundation)
- Placement objek 3D di lantai/meja
- Interaksi AR → menuju VR Scene
- Room-Scale VR menggunakan HP
- Movement dengan 1 jari (One Finger VR Move)
- Collision system (tidak tembus dinding)
- Pengujian performa + SSQ
- Build Android (APK)

## 📁 Struktur Repository
/src → semua script C# (AR, VR, Movement)
/assets → model 3D, textures, audio
/build → file APK untuk penguji
/docs → laporan akhir, PDF, flowchart
/demo → video demo aplikasi

## 🛠 Teknologi
- Unity 2021/2022/2023 LTS
- ARFoundation
- XR Plug-in Management
- Unity XR
- C# scripting

## ▶ Cara Build / Run
1. Buka Unity Hub → Open Project
2. Buka menu `Build Settings`
3. Pilih **Android**
4. Tekan `Switch Platform`
5. Tekan `Build` → hasilkan APK
6. Instal APK ke HP
7. AR Scene akan muncul pertama kali
8. Sentuh objek AR → masuk mode VR

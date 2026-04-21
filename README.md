# 🚀 User CRUD App (WinForms + API)

Aplikasi desktop berbasis **Windows Forms (C#)** untuk melakukan operasi **CRUD (Create, Read, Update, Delete)** terhadap data user menggunakan REST API.

---

## 📌 Deskripsi

Project ini dibuat untuk memenuhi tugas pemrograman dengan tujuan:

* Menghubungkan aplikasi WinForms dengan API
* Mengolah data JSON
* Menampilkan data dalam DataGridView
* Melakukan operasi CRUD secara lengkap

API yang digunakan:
https://dummy-user-api-omega.vercel.app/api/users

---

## ✨ Fitur Utama

✔ **Read Many (Load Data)**
Menampilkan semua data user ke dalam tabel

✔ **Read One (Get by ID)**
Mengambil data user berdasarkan ID

✔ **Create**
Menambahkan user baru ke database

✔ **Update**
Mengubah data user yang dipilih

✔ **Delete**
Menghapus data user

✔ **Auto Fill Form**
Klik tabel → otomatis isi textbox

✔ **Validasi Input**
Mencegah input kosong

---

## 🖥️ Tampilan Aplikasi

* Form sederhana & user-friendly
* DataGridView responsif
* Full CRUD dalam satu halaman

---

## 🛠️ Teknologi yang Digunakan

* C# (.NET Framework)
* Windows Forms
* HttpClient
* Newtonsoft.Json

---

## 📂 Struktur Project

UserCRUDApp/
│
├── Form1.cs            (Logic utama CRUD)
├── User.cs             (Model data user)
├── ApiResponse.cs      (Model response API)
├── Program.cs          (Entry point aplikasi)
└── README.md

---

## 🔧 Cara Menjalankan

1. Clone repository:
   git clone https://github.com/USERNAME/UserCRUDApp.git

2. Buka di Visual Studio

3. Jalankan:
   Start (F5)

---

## 🧪 Cara Penggunaan

1. Klik **Load Data** untuk menampilkan semua user
2. Klik salah satu baris untuk memilih data
3. Gunakan tombol:

   * Create → tambah data
   * Update → edit data
   * Delete → hapus data
   * Get by ID → cari berdasarkan ID

---

## ⚠️ Catatan

* Data berasal dari API publik
* ID bersifat unik dan panjang (normal)
* Beberapa data mungkin tidak memiliki email

---

## 🎯 Tujuan Pembelajaran

* Memahami konsep REST API
* Implementasi HttpClient di C#
* Parsing JSON ke object
* Integrasi UI dengan backend

---

## 👨‍💻 Author

Nama: Mohammad Fahmi Nazmuddin
Universitas: Universitas Negeri Jember
Program Studi: Teknologi Informasi

---

## ⭐ Penutup

Project ini dibuat sebagai latihan implementasi CRUD berbasis API pada aplikasi desktop.
Semoga bermanfaat dan dapat dikembangkan lebih lanjut 🚀

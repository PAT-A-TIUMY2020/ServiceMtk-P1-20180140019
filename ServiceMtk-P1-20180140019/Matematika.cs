using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static ServiceMtk_P1_20180140019.IMatematika;

namespace ServiceMtk_P1_20180140019
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    /// <summary>
    /// Main class
    /// </summary>
    /// <remarks>class matematika dapat membuat operasi Penjumlahan, Pengurangan, Perkalian, Pembagian, dan Titik Koordinat</remarks>
    public class Matematika : IMatematika
    {
        /// <summary>
        /// Operasi pembagian 
        /// </summary>
        /// <param name="a"> angka pertama dalam operasi pembagian </param>
        /// <param name="b"> angka kedua yang akan membagi angka pertama</param>
        /// <returns> hasil dari operasi bagi </returns>
        /// <exception cref=""
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }

        }

        /// <summary>
        /// Operasi Perkalian
        /// </summary>
        /// <param name="a"> angka pertama dalam operasi perkalian </param>
        /// <param name="b"> angka kedua yang akan mengalikan angka pertama </param>
        /// <returns> hasil dari operasi perkalian </returns>
        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        /// <summary>
        /// Operasi Pengurangan
        /// </summary>
        /// <param name="a"> angka pertama dalam operasi pengurangan </param>
        /// <param name="b"> angka kedua yang akan mengurangi angka pertama </param>
        /// <returns> hasil dari operasi pengurangan </returns>
        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        /// <summary>
        /// Operasi Penjumlahan
        /// </summary>
        /// <param name="a"> angka pertama dalam operasi penjumlahan </param>
        /// <param name="b"> angka kedua yang akan menjumlahkan angka pertama </param>
        /// <returns> hasil dari operasi penjumlahan </returns>
        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }


        //TKoordinat:nama methodnya, a,b = input seperti int.
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya dengan yb lalu dimasukkan ke hasil
        /// <summary>
        /// Operasi menentukan titik koordinat
        /// </summary>
        /// <param name="a"> angka koordinat pertama </param>
        /// <param name="b"> angka koordinat kedua </param>
        /// 
        /// <returns> hasil dari perhitungan (x = ax + bx), (y= ay + by) titik koordinat </returns>
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
    }
}
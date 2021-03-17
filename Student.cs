using System;
using System.Collections.Generic;
using System.Text;

namespace ögernciUygulaması
{
    public class Student
    {
        private string isim;
        private string soyisim;
        private int ögrno;
        private int vize1;
        private int vize2;
        private int final;
        private string okul;


        public Student(string _isim, string _soyisim, int _ögrno, int _vize1, int _vize2, int _final, string _okul)
        {
            isim = _isim;
            soyisim = _soyisim;
            ögrno = _ögrno;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okul = _okul;
        }


        public void ÖgrenciBilgileriGöster()
        {
            Console.WriteLine("Öğrenci ismi:"+ isim);
            Console.WriteLine("Öğrenci soyismi:" + soyisim);
            Console.WriteLine("Öğrenci no:" + ögrno);
            Console.WriteLine("Öğrenci vize1:" + vize1);
            Console.WriteLine("Öğrenci vize2:" + vize2);
            Console.WriteLine("Öğrenci final:" + final);
            Console.WriteLine("Öğrenci okulu:" + okul);
        }

        public double ÖgrenciOrtalamasınıBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            Console.WriteLine("Öğrenci Ortalaması:"+ ortalama);
            return ortalama;
        }
        public void OkulGetir()
        {
            Console.WriteLine("Öğrenci okulu:"+ okul);
        }

        
    }
}

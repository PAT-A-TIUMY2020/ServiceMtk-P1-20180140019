﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static ServiceMtk_P1_20180140019.Matematika;

namespace ServiceMtk_P1_20180140019
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        [FaultContract(typeof(MathFault))]
        int Tambah(int a, int b);

        [OperationContract]
        int Kurang(int a, int b);

        [OperationContract]
        int Kali(int a, int b);

        [OperationContract]
        int Bagi(int a, int b);

        [OperationContract]
        Koordinat TKoordinat(Koordinat a, Koordinat b);

    }

    [DataContract]
    class MathFault
    {
        [DataMember]
        public string Kode { get; set; }
        [DataMember]
        public string Pesan { get; set; }
    }

    public class Koordinat
    {
        private int _x, _y; //atribut
        [DataMember]//membuka koordinat, x,y
        public int X //properties
        {
            get { return _x; }
            set { _x = value; }
        }
        [DataMember]
        public int Y //properties
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
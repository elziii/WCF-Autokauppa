using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AutokauppaWCF
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool TestDatabaseConnection();

        [OperationContract]
        bool saveAuto(Auto newAuto);

        [OperationContract]
        List<AutonMerkki> getAllAutoMakers();

        [OperationContract]
        List<AutonMalli> getAutoModels(int makerId);

        [OperationContract]
        List<Polttoaineet> GetPolttoaine();

        [OperationContract]
        List<Varit> GetVari();

        [OperationContract]
        int GetMinId();

        [OperationContract]
        int GetMaxId();

        [OperationContract]
        Auto NextPrevAuto(int autoId, bool next, bool prev);

        [OperationContract]
        void DeleteAuto(int autoId);
    }

    [DataContract]
    public class Auto
    {
        int ID, Mittarilukema, AutonMerkkiID, AutonMalliID, VaritID, PolttoaineID;
        decimal Hinta, Moottorin_tilavuus;
        DateTime Rekisteri_paivamaara;

        [DataMember]
        public int ID1 { get => ID; set => ID = value; }
        [DataMember]
        public int Mittarilukema1 { get => Mittarilukema; set => Mittarilukema = value; }
        [DataMember]
        public int AutonMerkkiID1 { get => AutonMerkkiID; set => AutonMerkkiID = value; }
        [DataMember]
        public int AutonMalliID1 { get => AutonMalliID; set => AutonMalliID = value; }
        [DataMember]
        public int VaritID1 { get => VaritID; set => VaritID = value; }
        [DataMember]
        public int PolttoaineID1 { get => PolttoaineID; set => PolttoaineID = value; }
        [DataMember]
        public decimal Hinta1 { get => Hinta; set => Hinta = value; }
        [DataMember]
        public decimal Moottorin_tilavuus1 { get => Moottorin_tilavuus; set => Moottorin_tilavuus = value; }
        [DataMember]
        public DateTime Rekisteri_paivamaara1 { get => Rekisteri_paivamaara; set => Rekisteri_paivamaara = value; }
    }

    [DataContract]
    public class AutonMerkki
    {
        int ID;
        string Merkki;

        [DataMember]
        public int ID1 { get => ID; set => ID = value; }
        [DataMember]
        public string Merkki1 { get => Merkki; set => Merkki = value; }
    }

    [DataContract]
    public class AutonMalli
    {
        int ID, AutonMerkkiID;
        string Auton_mallin_nimi;

        [DataMember]
        public int ID1 { get => ID; set => ID = value; }
        [DataMember]
        public int AutonMerkkiID1 { get => AutonMerkkiID; set => AutonMerkkiID = value; }
        [DataMember]
        public string Auton_mallin_nimi1 { get => Auton_mallin_nimi; set => Auton_mallin_nimi = value; }
    }

    [DataContract]
    public class Polttoaineet
    {
        int ID;
        string Polttoaineen_nimi;

        [DataMember]
        public int ID1 { get => ID; set => ID = value; }
        [DataMember]
        public string Polttoaineen_nimi1 { get => Polttoaineen_nimi; set => Polttoaineen_nimi = value; }
    }

    [DataContract]
    public class Varit
    {
        int ID;
        string Varin_nimi;

        [DataMember]
        public int ID1 { get => ID; set => ID = value; }
        [DataMember]
        public string Varin_nimi1 { get => Varin_nimi; set => Varin_nimi = value; }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOT: "Service1" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    // NOT: Bu hizmeti test etmek üzere WCF Test İstemcisi'ni başlatmak için lütfen Çözüm Gezgini'nde Service1.svc'yi veya Service1.svc.cs'yi seçin ve hata ayıklamaya başlayın.
    public class Service1 : IService1
    {
        public static string sqlBaglantiDemo = "Database=oop_2; Data Source=localhost; UID=_localhost; PASSWORD= password";
        MySqlConnection baglantiDemo= new MySqlConnection(Service1.sqlBaglantiDemo);
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        int err = 0;
        public int personelEkle(string ad,string soyad,int tur)
        {
            baglantiDemo.Open();
            MySqlCommand personelEkleCommand = new MySqlCommand("insert into personel(ad,soyad,tur) values ('" + ad + "','" + soyad +"',"+tur+")",baglantiDemo);
            int sonuc=personelEkleCommand.ExecuteNonQuery();
            if(sonuc==0)
            {
                err++;
            }
            baglantiDemo.Close();
            return err;
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
